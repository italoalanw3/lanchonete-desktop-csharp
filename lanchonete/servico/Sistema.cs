using projeto_escola.modelo.entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

class Sistema
{
    public static String AMBIENTE_DESENVOLVIMENTO = "desenvolvimento";
    public static String AMBIENTE_PRODUCAO = "producao";
    /** True or False */
    public static bool _logErro { get; private set; }
    /** True or False */
    public static bool _logDebug { get; private set; }

    /** True or False */
    public static bool _logInfo { get; private set; }

    /** Server=localhost;database=lanchonete;user id=postgres;password=senha@123 */
    public static String _conexaoBanco { get; private set; }

    public static String _ambiente { get; private set; }
    //<property name="connection.connection_string">Server=localhost;database=lanchonete;user id=postgres;password=senha@123</property>

    private static Queue<String> filaLogErro, filaLogDebug, filaLogInfo;


    public static void carregarConfiguracoes()
    {
        try
        {
            _logErro = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["LogErro"]);
            _logDebug = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["LogDebug"]);
            _logInfo = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["LogInfo"]);

            _conexaoBanco = System.Configuration.ConfigurationManager.ConnectionStrings["conexaoBanco"].ConnectionString;

            _ambiente = System.Configuration.ConfigurationManager.ConnectionStrings["ambiente"].ConnectionString;

            filaLogErro = filaLogDebug = filaLogInfo = new Queue<String>();
        }
        catch (Exception e)
        {
            throw new Exception("Não foi possivel carregar todas as variáveis de ambiente do sistema: " + e.Message);
        }
    }

    public static Usuario usuarioLogado { get; set; }

    //------------------------------------------------------------------------------------
    public static bool campoIsNull(String campo)
    {
        if (campo.Equals(""))
            return true;
        else
            return false;
    }

    public static bool numeroInvalido(String valor)
    {
        try
        {
            double valor2 = Convert.ToDouble(valor);
            if (valor2 <= 0)
                return true;
            else
                return false;
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
        }
        return false;
    }

    public static void escreverLogs()
    {
        escreverLogDebugFila();
        escreverLogErroFila();
        escreverLogInfoFila();
    }

    private static void escreverLogDebugFila()
    {
        try
        {
            if (filaLogInfo.Count() > 0)
            {
                String path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                String dataHora = DateTime.Now.ToString("ddMMyyyy");
                String nomeArquivo = path + "\\Log\\Debug\\" + dataHora + ".txt";

                using (StreamWriter sw = File.AppendText(nomeArquivo))
                {

                    sw.WriteLine(filaLogInfo.Dequeue());
                }
            }
        }
        catch (DirectoryNotFoundException e)
        {
            throw new Exception("Falta criar pasta Debug dentro da pasta Log: ..\\Log\\Debug\\" + e.Message);
        }
        catch (IOException)
        {
            return;
        }
    }

    private static void escreverLogErroFila()
    {
        try
        {
            if (filaLogErro.Count() > 0)
            {
                String path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                String dataHora = DateTime.Now.ToString("ddMMyyyy");
                String nomeArquivo = path + "\\Log\\Erro\\" + dataHora + ".txt";

                using (StreamWriter sw = File.AppendText(nomeArquivo))
                {

                    sw.WriteLine(filaLogErro.Dequeue());
                }
            }
        }
        catch (DirectoryNotFoundException e)
        {
            throw new Exception("Falta criar pasta Erro dentro da pasta Log: ..\\Log\\Erro\\" + e.Message);
        }
        catch (IOException)
        {
            return;
        }

    }

    private static void escreverLogInfoFila()
    {
        try
        {
            if (filaLogInfo.Count() > 0)
            {
                String path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                String dataHora = DateTime.Now.ToString("ddMMyyyy");
                String nomeArquivo = path + "\\Log\\Info\\" + dataHora + ".txt";

                using (StreamWriter sw = File.AppendText(nomeArquivo))
                {
                    sw.WriteLine(filaLogInfo.Dequeue());
                }
            }
        }
        catch (DirectoryNotFoundException e)
        {
            throw new Exception("Falta criar pasta Log dentro da pasta Log: ..\\Log\\Log\\" + e.Message);
        }
        catch (IOException)
        {
            return;
        }
    }

    public static void logDebug(String texto)
    {
        filaLogDebug.Enqueue(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + ": " + texto);
    }

    public static void logErro(String texto)
    {
        filaLogErro.Enqueue(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + ": " + texto);
    }

    public static void loginfo(String texto)
    {
        filaLogInfo.Enqueue(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + ": " + texto);
    }

    //------------------------------------------------------------------------------------

    private static DataTable ConvertToDataTable<T>(List<T> data)
    {
        PropertyDescriptorCollection properties =
           TypeDescriptor.GetProperties(typeof(T));
        DataTable table = new DataTable();
        foreach (PropertyDescriptor prop in properties)
            table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
        foreach (T item in data)
        {
            DataRow row = table.NewRow();
            foreach (PropertyDescriptor prop in properties)
                row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
            table.Rows.Add(row);
        }
        return table;
    }

    public static bool pesquisaDataGridView<T>(BindingSource binding, DataGridView dgv, List<T> dadosLista, string pesquisa)
    {
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        binding.DataSource = Sistema.ConvertToDataTable<T>(dadosLista);

        // Set the data source for the DataGridView.
        dgv.DataSource = binding;
        binding.Filter = pesquisa;
        if (binding.Count <= 0)
            return false;
        else
            return true;
    }

    public static string GetMd5Hash(MD5 md5Hash, string input)
    {

        // Convert the input string to a byte array and compute the hash.
        byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

        // Create a new Stringbuilder to collect the bytes
        // and create a string.
        StringBuilder sBuilder = new StringBuilder();

        // Loop through each byte of the hashed data 
        // and format each one as a hexadecimal string.
        for (int i = 0; i < data.Length; i++)
        {
            sBuilder.Append(data[i].ToString("x2"));
        }

        // Return the hexadecimal string.
        return sBuilder.ToString();
    }

    // Verify a hash against a string.
    public static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
    {
        // Hash the input.
        string hashOfInput = GetMd5Hash(md5Hash, input);

        // Create a StringComparer an compare the hashes.
        StringComparer comparer = StringComparer.OrdinalIgnoreCase;

        if (0 == comparer.Compare(hashOfInput, hash))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

namespace udkXMLTemplate
{
    using System.IO.Compression;
    public class UdkXML
    {
        private static Random random = new Random();
        private static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private static void DeleteDirectory(string target_dir)
        {
            string[] files = Directory.GetFiles(target_dir);
            string[] dirs = Directory.GetDirectories(target_dir);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(target_dir, false);
        }


        public bool applyTemplate(String file, String output, KeyValuePair<String, String>[] template)
        {
            try
            {
                //geçici klasör oluştur.
                String tempFolder = AppDomain.CurrentDomain.BaseDirectory + RandomString(32) + @"\";

                //arşivi çıkart.
                ZipFile.ExtractToDirectory(file, tempFolder);

                //tüm xml dosyalarını oku.
                string[] xmlFiles = System.IO.Directory.GetFiles(tempFolder, "*.xml", SearchOption.AllDirectories);

                //tüm xml dosyalarını tek tek aç.
                String temp = "";
                foreach (String xml in xmlFiles)
                {
                    //gerekli değişiklikleri yap
                    temp = File.ReadAllText(xml);

                    foreach (KeyValuePair<String, String> kvp in template)
                    {
                        temp = temp.Replace("{"+kvp.Key+"}", kvp.Value);
                    }

                    File.WriteAllText(xml, temp);
                }

                //klasörü tekrar paketle
                //mevcutsa sil
                if (File.Exists(output))
                    File.Delete(output);
                //paketi oluştur.
                ZipFile.CreateFromDirectory(tempFolder, output);

                //klasörü imha et.
                DeleteDirectory(tempFolder);

                return true;
            }catch(Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            

        }
    }
}
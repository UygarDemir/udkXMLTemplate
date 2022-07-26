using udkXMLTemplate;

//udkXML nesnesi oluşturuyoruz
UdkXML udkXML = new UdkXML();

//şabloda değişmesi gereken noktaları KeyValuePair dizesi içerisine tanımlıyoruz.
//*****
//KeyValuePair'in key kısmına şablon dosyada {} arasına yazdığımız yer tutucu adı
//gelmeli. Value kısmına ise yer tutucunun yerine gelecek veriyi ekliyoruz.
KeyValuePair<String, String>[] template = { 
    new KeyValuePair<String, String>("test1", "Dünya!"), 
    new KeyValuePair<string, string>("test2", "iki"),
    new KeyValuePair<string, string>("degisecek", "değişti!")
};
String path = @"C:\Users\Uygar_DK\source\repos\udkXMLTemplate\templateExamples\";
String templateFile = path+@"example2.docx";
String saveTo = path + @"test2.docx";
//fonksiyonu çağırıyoruz. 
//1.parametreye şablon dosya yolunu (String),
//2.parametreye oluşan yeni dosyanın kaydedileceği konumu (String),
//3.parametreye ise yukarıda oluşturduğumuz KeyValuePair dizesini (KeyValuePair[])
//ekliyoruz. (Şu anda Key-Value değerleri yalnızca String olabilir)
udkXML.applyTemplate(templateFile, saveTo, template);
//Başarıyla kayıt gerçekleştiğinde program true değeri döndürecektir.
//Herhangi bir hata durumunda false değeri dönecek ve hatayla ilgili ayrıntılar
//konsol ekranına basılacaktır.
# udkXMLTemplate
Arşivlenmiş XML dokümanlarında bulunan yer tutucuları kolayca değiştirin.

Bu program ofis dosyalarındaki yer tutucuları kolaylıkla değiştirmenizi sağlar. Böylece bir Microsoft Excel, Word, PowerPoint, Open Document Format (ODF) dosyasını şablon olarak kullanarak dilediğiniz değerleri programınız ile değiştirip güncelleyebilirsiniz. Bu küçük DLL dosyası XML tabanlı ofis dosyalarındaki yer tutucuları kolayca değiştirmenizi sağlar.

Örnek 1: Aşağıda şablon olarak kullanılmış .XLSX uzantılı dosya görüyorsunuz. Bu dosyadaki {test1}, {test2}, {degisecek} yer tutucularını programımızdan girdiğimiz değerlerle değiştirip farklı bir dosyaya kaydedeceğiz. 
![ex1](https://user-images.githubusercontent.com/20663773/181023837-3543625c-2bc8-48da-9371-a371a1f73bb1.JPG)

**Bu yer tutucuları güncellemek için gereken kodu görelim.**
![ex2](https://user-images.githubusercontent.com/20663773/181028470-c6d7d670-ce3c-489e-a615-79605fdcab87.JPG)

**Yeni oluşan dosya:**
![ex3](https://user-images.githubusercontent.com/20663773/181028927-a37da723-591a-4fe1-98f3-cdd028954bb5.JPG)

**Word Dosyası İçin Örnek:**
![ex](https://user-images.githubusercontent.com/20663773/181035363-b25465a2-0bce-47c5-a09a-2242f24b7566.JPG)


Bu sayede ofis dokümanı şeklinde çıktı vermeniz gereken uygulamalarda şablon kullanarak kolayca işleminizi tamamlayabilirsiniz. Word ve PowerPoint dosyalarında da çalışmaktadır.  Var olan projenize çalışmamı dahil etmek için derlenmiş DLL dosyasını projenize ekleyebilirsiniz. (Çözüm Gezgini içerisinde projeye sağ tıklayıp, ekle kısmından proje başvurusu seçeneğini seçip, çıkan pencereden gözat yardımıyla indirdiğiniz DLL dosyasını ilave edebilirsiniz.) udkXMLTest projesi, udkXML kütüphanesinin kullanımıyla ilgili bir örnek içerir. SaveFileDialog gibi özellikleri kullanarak daha gelişmiş ve işlevsel programlar yazılabilir. Şablonların resources içerisine yüklenerek programın içine gömülmesi sağlanabilir. Ben böyle bir örneği resources içindeki dosyayı geçici olarak başka bir konuma kaydederek denedim. Programa bunu doğrudan yapan bir özellik eklemeyi düşünüyorum. Umarım faydalı bir çalışma olur.

**Uyarı: Bu yazılım beta aşamasında olup, temel düzeyde işlevsellik sağlar. Geliştirme süreci devam etmektedir. Hata bildirimleri ve güncelleme talepleri için issues kısmından benimle iletişime geçebilirsiniz.**

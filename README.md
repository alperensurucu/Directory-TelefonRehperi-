Directory Proje Katmanları :
Directory.Bll=>Repository pattern uyguladığımız katman 
Directory.DAL=>Db context , migration işlemlerinin bulunduğu katman .
Directory.MAP=>Entity Framework ,fulientApi içindeki konfigurasyon sınıflarının oluşturulduğu katman .
Directory.Model=>Veri tabanı modellerinin Dto sınıflarımızın , enumlarımızın bulunduğu katman .

Directory.UI====>> Controllerlarımızın ve kullanıcı ile etkileşime geçen  Viewlarımızın (create, edit, delete update cshtml dosyalarını eklemedim . bir önceki projede tam olarak paylaştığım için .) bulunduğu katman .
Dal  katmanına ek olarak  da  katmanda migration işlemlerimizi yağıyoruz. 
"AllowedHosts": "*",
    "ConnectionStrings": {
        "Mssql": "server=.;database=MyDirectory;uid=sa;pwd=123" işlemlerini de verileri tutmak için .json dosyasına eklemeyi unutmamalıyız.


using _240318_01___Aula_5.Models;

//Instancia de Objeto de tipo Custumer
Custumer c1 = new Custumer();

//Atribuindo valores aos atributos do objeto c1
c1.CustumerId = 1;
c1.FirstName = "Luiz Henrique";
c1.LastName = "Grazziotin de Oliveira";
c1.BirthDate = new DateTime();
c1.EmailAdress = "luiz.grazziotin@gmail.com";

//Instancia de Objeto do tipo Address
Address address1 = new Address();

//Atribuindo valores aos atributos do objeto Address1
address1.AddressId = 1;
address1.Street = "Ernesto Andreani";
address1.District = "Potal das Videiras";
address1.City = "Videira";
address1.Number = 28;
address1.FederalState = "SC";
address1.Coutry = "Brasil";
address1.ZipCode = "89562-402";
//AddressType é do tipo Enum - Portanto espera receber valor equivalente ao seu tipo
address1.AddressType = AddressType.Commercial;

//Para add na list de address
//Guardando um endereço à lista de endereços do consumidor
c1.Addresses.Add(address1);

Console.WriteLine("ENDEREÇO: ");
foreach(var ad in c1.Addresses)
{
    Console.WriteLine("-------------------------");
    Console.WriteLine($"Rua: {ad.Street}");
    Console.WriteLine($"Bairro: {ad.District}");
    Console.WriteLine($"Numero: {ad.Number}");
    Console.WriteLine($"Cidade: {ad.City}");
    Console.WriteLine($"Estado: {ad.FederalState}");
    Console.WriteLine($"País: {ad.Coutry}");
}

Console.WriteLine("\n");

Console.WriteLine("DADOS PESSOAIS: ");
Console.WriteLine("-------------------------");
Console.WriteLine($"Nome: {c1.FirstName} {c1.LastName} ");
Console.WriteLine($"Email: {c1.EmailAdress}");

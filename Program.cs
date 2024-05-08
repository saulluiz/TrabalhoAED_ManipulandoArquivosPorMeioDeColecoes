using System.Reflection;


/* listaPessoas.Add(new People(listaPessoas.Count,"22","Saulo","Luiz","male",null,"21/03/2005","Estudante"));
listaPessoas.Add(new People(listaPessoas.Count,"20","adsad","Luiz","male",null,"21/03/2005","Estudante"));
listaPessoas.Add(new People(listaPessoas.Count,"200","IIIIII","Luiz","male","email","21/03/2005","Estudante"));
foreach(var x in listaPessoas){
    Console.WriteLine(x.ToString());
}
 */
  
  var data=  DataReader.CsvToListaPeople("Data/people-100.csv");

  var data2=  DataReader.CsvToPeopleList("Data/people-100.csv");
 
   Console.WriteLine(data[99].ToString());

data.Add(new People(data.count,"a","b","c","d","e","f","g","asdasd"));
Console.WriteLine(data[100].ToString());
Console.WriteLine(data.count);
Console.WriteLine("removendo final : " + data.removeFim());//O retorno do console.writeline busca o metodo ToString da classe
Console.WriteLine(data.count);
data.InserirMeio(new People(data.count,"a","b","c","d","e","f","g","asdasd"),2);
data.InserirMeio(new People(data.count,"a","b","c","d","e","f","g","asdasd"),3);
data.imprimir();
Console.WriteLine(data.count);
Console.WriteLine("removendo 2 : " + data.Remove(2));
Console.WriteLine(data.count);
Console.WriteLine("removendo inicio : " + data.removeinicio());
Console.WriteLine(data.count);
data.Add(new People(data.count,"a","b","c","d","e","f","g","asdasd"));

Console.WriteLine(data.count);
data.Add(new People(data.count,"a","b","c","d","e","f","g","asdasd"));
data.Add(new People(data.count,"a","b","c","d","e","f","g","asdasd"));
Console.WriteLine(data.count);
System.Console.WriteLine(data[102].ToString());
Console.WriteLine(data.count);
System.Console.WriteLine("__________________________________________________");
data.InserirInicio(new People(111,"a","b","c","d","e","f","g","asdasd"));
data.imprimir();
Console.WriteLine(data.count);
using System.Reflection;

List<People> listaPessoas=new List<People>();

/* listaPessoas.Add(new People(listaPessoas.Count,"22","Saulo","Luiz","male",null,"21/03/2005","Estudante"));
listaPessoas.Add(new People(listaPessoas.Count,"20","adsad","Luiz","male",null,"21/03/2005","Estudante"));
listaPessoas.Add(new People(listaPessoas.Count,"200","IIIIII","Luiz","male","email","21/03/2005","Estudante"));
foreach(var x in listaPessoas){
    Console.WriteLine(x.ToString());
}
 */
 
  var data=  DataReader.CsvToPeopleList("Data/people-10000.csv");
  Console.WriteLine(data[0].ToString());

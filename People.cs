/* Classe em C#: Crie a classe People. Sua classe terá os atributos index (int),
userId (string), firtName (string), lastName (string), sex (string), email (string),
dateOfBirth (string), jobTitle (string). Sua classe terá pelo menos dois
contrutores e o método ToString() que retorna uma string com os dados do
objeto no seguinte formato: 
*/
using System.Text;
using System.Reflection;
using System.Reflection.Metadata;


public class People
{


  public People(int index, string userId, string firtName, string lastName, string sex, string email, string phone, string dateOfBirth, string jobTitle)
  {
    this.Index = index;
    this.UserId = userId;
    this.FirtName = firtName;
    this.LastName = lastName;
    this.Sex = sex;
    this.Email = email;
    this.Phone = phone;
    this.DateOfBirth = dateOfBirth;
    this.JobTitle = jobTitle;
  }
  public People(int index)
  {
    this.Index = index;
    this.UserId = null;
    this.FirtName = null;
    this.LastName = null;
    this.Sex = null;
    this.Email = null;
    this.Phone = null;
    this.DateOfBirth = null;
    this.JobTitle = null;
  }

  public People(string people)
  {
    string[] peopleData = people.Split(",");
    this.Index = int.Parse(peopleData[0]);
    this.UserId = peopleData[1];
    this.FirtName = peopleData[2];
    this.LastName = peopleData[3];
    this.Sex = peopleData[4];
    this.Email = peopleData[5];
    this.Phone = peopleData[6];
    this.DateOfBirth = peopleData[7];
    this.JobTitle = jobTitleWithComma(peopleData);
  }
  private string jobTitleWithComma(string[] peopleData)
  {
    //Garante que a divisao com virgulas nao quebre o nome de um trabalho, caso esse esteja separado por virgulas.
    if (peopleData.Length > 9)
    {
      StringBuilder aux = new StringBuilder();
      for (int i = 8; i < peopleData.Length-1; i++)
      {
        aux.Append(peopleData[i]);
        aux.Append(",");

      }
       aux.Append(peopleData[peopleData.Length-1]);
      return aux.ToString();
    }
    return peopleData[8];
  }

  public int Index { get; set; }
  public string? UserId { get; set; }
  public string? FirtName { get; set; }
  public string? LastName { get; set; }
  public string? Sex { get; set; }
  public string? Email { get; set; }
  public string? Phone { get; set; }

  public string? DateOfBirth { get; set; }
  public string? JobTitle { get; set; }
  public override string ToString()
  {



    StringBuilder text = new StringBuilder();
    Type tipo = this.GetType();
    PropertyInfo[] propriedades = tipo.GetProperties();
    text.Append("[");

    foreach (PropertyInfo propriedade in propriedades)
    {

      string textAux = $"{propriedade.GetValue(this)}";
      if (!textAux.Equals(""))
      {
        text.Append("## " + textAux + " ");
      }
    }

    text.Append(" ##]");
    return text.ToString();

  }




}









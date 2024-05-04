/* Classe em C#: Crie a classe People. Sua classe terá os atributos index (int),
userId (string), firtName (string), lastName (string), sex (string), email (string),
dateOfBirth (string), jobTitle (string). Sua classe terá pelo menos dois
contrutores e o método ToString() que retorna uma string com os dados do
objeto no seguinte formato: 
*/
using System.Text;
using System.Reflection;


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
  public People(string people)
  {
    string[] peopleData = new string[9];
    peopleData = people.Split(",");
    this.Index = int.Parse(peopleData[0]);
    this.UserId = peopleData[1];
    this.FirtName = peopleData[2];
    this.LastName = peopleData[3];
    this.Sex = peopleData[4];
    this.Email = peopleData[5];
    this.Phone = peopleData[6];
    this.DateOfBirth = peopleData[7];
    this.JobTitle = peopleData[8];
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

    foreach (PropertyInfo propriedade in propriedades)
    {

      string textAux = $"{propriedade.GetValue(this)}";
      if (!textAux.Equals(""))
      {
        text.Append("## " + textAux + " ");
      }
    }

    text.Append(" ##");
    return text.ToString();

  }




}









using Microsoft.Extensions.Diagnostics.HealthChecks;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using System.Reflection.Metadata.Ecma335;
using spAutoComplete.Models.autoComplete;

namespace spAutoComplete.Models.autoComplete
{
    public enum Status
    {
        inactive = 0 ,
        idle=  1,
        processing=2
    }
}

public sealed class AutoCompleteList
    {
    private String values = "";
    private String path = "";
    private String FileName = "";
    public Boolean IsActive()
    {
        return this.status == Status.idle;
    } 
    public void SetFileName(String fileName)
    {
        if (!fileName.Equals(this.FileName))
        {
            this.SetStatus(Status.inactive);
            this.FileName = fileName;
            this.path = "./Models/autoComplete/resource/" + fileName;
            this.LoadList(path);
        }
    }
    private Status status = Status.inactive;
    public Status GetStatus() { return this.status; }
    private void SetStatus(Status status) { this.status = status;}
   
    public List<String> Match(String strinToSearch)
    {
        if (!this.IsActive())
        {
            return new List<String>();
        }
        try
        {
            //\b^al(.*)
            this.SetStatus(Status.processing);
            String pattern = @"\b^" + strinToSearch + "(.*)";
            RegexOptions options = RegexOptions.Multiline;
            List<String> ret = Regex.Matches(values, pattern, options).Cast<Match>()
                   .Select(m => m.Value)
                   .ToList();
            this.SetStatus(Status.idle);

            return ret;
        }
        catch (Exception)
        {
            this.SetStatus(Status.idle);
            return new List<String>();
        }
    }
    //--------------------------------------------
    private void LoadList(String path)
    {

        try
        {
            this.values = File.ReadAllText(path).ToLower();
            this.SetStatus(Status.idle);
        }
        catch (Exception)
        {
            Console.WriteLine("failed to load list from" + path);
            this.values = "";
            this.path = "";
            this.FileName = "";
            this.SetStatus(Status.inactive);
        }

    }

    // singletone pattern building Stones
     
    private static AutoCompleteList? _instance = null;
    private static readonly object chekLock = new();
    private AutoCompleteList()
    {

    }
    public static AutoCompleteList Instance
    {
        get {
            lock (chekLock)
            {
                _instance ??= new AutoCompleteList();

                return _instance;
            }
        }
    }


    

    public void  refresh()
    {

    }

    public void addList (String listName, String values )
    {

    }

    public void addValue (String listName , String value)
    {

    }






}

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
    public void SetFileName(string fileName)
    {
        if (!fileName.Equals(this.FileName))
        {
            this.SetStatus(Status.inactive);
            this.path = "./Models/autoComplete/resource/" + fileName;
            this.FileName = fileName;
            this.LoadList();
        }
    }
    private Status status = Status.inactive;
    public Status GetStatus() { return this.status; }
    private void SetStatus(Status status) { this.status = status;}
   
    public List<string> Match(string strinToSearch)
    {
        if (!this.IsActive())
        {
            return new List<string>();
        }
        try
        {
            //\b^al(.*)
            this.SetStatus(Status.processing);
            string pattern = @"\b^" + strinToSearch + "(.*)";
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
            return new List<string>();
        }
    }
    //--------------------------------------------
    private void LoadList()
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

 
    






}

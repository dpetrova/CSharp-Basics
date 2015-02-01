using System; 
using System.Collections.Generic; 
using System.IO; 
using System.Linq;

class AverageLoadTimeCalculator 
{
    //put a report in: \CSharp-Advanced-Topics-Homework\13.AverageLoadTimeCalculator\bin\Debug\file.txt

    static void Main() 
    { 
        // Fix the decimal separator to be dot 
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        // This program reads the report from the file.txt (Visual Studio 2010\Projects\CSharp-Advanced-Topics-Homework\13.AverageLoadTimeCalculator\bin\Debug) 
        StreamReader reportReader = new StreamReader("file.txt");
        //read the stream from the current position to the end of the stream and assign it in a string
        string report = reportReader.ReadToEnd();
        //split the report to substrings; separator - New line; if there are empty substrings, remove them
        string[] reportEntries = report.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);  
        Dictionary<string, List<double>> reportTimes = new Dictionary<string, List<double>>(); 
        foreach (var entry in reportEntries) 
        {
            string[] line = entry.Split(' ');  //split every string in reportEntries; separator is space
            if(! reportTimes.ContainsKey(line[2])) //if dictionary doesn't contain the key (particular URL - it is the [2] element of split)
            {
                reportTimes[line[2]] = new List<double>() { double.Parse(line[3]) }; //it is create a key "URL" (split[2]) and value "Time" (split[3] - it is [3] element of split)
            } 
            else 
            {
                reportTimes[line[2]].Add(double.Parse(line[3])); //if dictionary already contains the key (particular URL), just add another value to its list of values
            } 
        } 
        foreach (var entry in reportTimes) 
        { 
            Console.WriteLine("{0} -> {1}", entry.Key, entry.Value.Average()); 
        } 
    } 
} 

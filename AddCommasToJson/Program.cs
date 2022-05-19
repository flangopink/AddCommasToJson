using System.Text.RegularExpressions;

Regex Validator = new(@"^[\t\]\}]+$");
string newFilePath;

bool IsValid(string str)
{
    return Validator.IsMatch(str);
}

string inputFile;

if (args.Length > 0)
{
    foreach (string arg in args)
    {
        inputFile = arg;

        Directory.CreateDirectory("output");
        newFilePath = Path.GetDirectoryName(inputFile) + "\\output\\" + Path.GetFileName(inputFile);
        File.Delete(newFilePath);

        string[] fileLines = File.ReadAllLines(inputFile);

        string line;

        for (int i = 0; i < fileLines.Length; i++)
        {
            line = fileLines[i];

            if (i == fileLines.Length - 1)
            {
                Write(line);
                break;
            }

            if (line.EndsWith(',') || (fileLines[i + 1].EndsWith("},") || fileLines[i + 1].EndsWith("],")))
            {
                Write(line);
                continue;
            }

            if (!line.EndsWith('{') && !line.EndsWith('[') && !IsValid(fileLines[i + 1]))
                line += ",";

            if (line.Contains("default_hide_dependency_lines")) line = "";

            if (line != "")
                Write(line);
        }
    }
}

void Write(string line)
{
    using (StreamWriter sw = File.AppendText(newFilePath))
        sw.WriteLine(line);

    Console.WriteLine(line);
}
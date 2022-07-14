// See https://aka.ms/new-console-template for more information
using JsonToTable.Utilities;



JsonFileUtilties fileUtilties = new JsonFileUtilties();

//var inputFilePath = "H:\\01_PrivateRepos\\Ace.Digital.JsonToTable\\Sample.json";
//var outputFilePath = "H:\\01_PrivateRepos\\Ace.Digital.JsonToTable\\SampleOutput.table";
var inputFilePath = args[0].ToString();
var outputFilePath = args[1].ToString();
var itemsListObj = fileUtilties.ReadJsonFile(inputFilePath);
fileUtilties.WriteTableFile(outputFilePath, items: itemsListObj.Items.Item);


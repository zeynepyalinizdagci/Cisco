using HttpTagServer;
using HttpTagServer.Models;

var server = new TagServer();
var tagName = "animal";
var doc = server.GetDocumentByTag(tagName);
Console.WriteLine(doc);
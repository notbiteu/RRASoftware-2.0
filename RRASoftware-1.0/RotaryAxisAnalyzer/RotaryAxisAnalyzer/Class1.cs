using MongoDB.Bson;
using OxyPlot.Axes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace RotaryAxisAnalyzer
{
    internal class Class1
    {
    }
    public class MeasurementDetails
    {
        public ObjectId Id { get; set; }
        public string testTitle { get; set; }
        public string operatorName { get; set; }
        public string notes { get; set; }
        public string machineName { get; set; }
        public string serialNumberMachine { get; set; }
        public string Axis { get; set; }
    }

    public static class Globals
    {
        public static string connectionString = "mongodb://localhost:27017/";
        public static string databaseName = "myRotary";
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexTypes
{
    public abstract class Report
    {
        public DateTime CreationTime { get; set; }
        public string Title { get; set; }
        public Employee Owner { get; set; }

        public void SendReport(string to)
        {
            Console.WriteLine($"Rapor,{to} kişisine gönderildi");
        }

        //public abstract void Print();        
        public abstract void Save();
        public abstract void GetDataFromReport();  
      
    }

    public interface IPrintable
    {
        void Print();
    }

    public class SalesReport : Report, IPrintable
    {
        public override void GetDataFromReport()
        {
            Console.WriteLine("Sales Report için veri çekildi");
        }

        public void Print()
        {
            Console.WriteLine("Sales Report çıktısı alındı");

        }

        public override void Save()
        {
            Console.WriteLine("Sales Report kaydedildi");

        }
    }

    public class PerformanceReport : Report, IPrintable
    {
        public override void GetDataFromReport()
        {
            Console.WriteLine("Performance Report için veri çekildi");
        }

        public  void Print()
        {
            Console.WriteLine("Performance Report çıktısı alındı");

        }

        public override void Save()
        {
            Console.WriteLine("Performance Report kaydedildi");

        }
    }
    public class WeeklySummaryReport: Report
    {
        public override void GetDataFromReport()
        {
            Console.WriteLine("WeeklySummary Report için veri çekildi");
        }

        

        public override void Save()
        {
            Console.WriteLine("WeeklySummary Report kaydedildi");

        }
    }


    public class ReportPrinter
    {
        public void Print(IPrintable report)
        {
            report.Print();
        }
    }
}

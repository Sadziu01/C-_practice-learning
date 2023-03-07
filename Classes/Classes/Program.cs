﻿using Classes;
using ClassLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        //Person bill = new Person("Bill", "Wick");

        //bill.SetDateOfBirth(new DateTime(1990, 1, 1));

        //bill.SayHi();
        //bill.ContactNumber = "999888777";
        //Console.WriteLine(bill.ContactNumber);


        //Person john = new Person(new DateTime(1990, 1, 2), "John", "Wick");
        //john.SayHi();

        //Console.WriteLine($"Objects of Person type count: {Person.Count}");





        //ExcelFile excelFile = new ExcelFile();

        //excelFile.CreatedOn = DateTime.Now;
        //excelFile.FileName = "excel-file";

        //excelFile.GenerateReport();

        //WordDocumentFile wordDocumentFile = new WordDocumentFile();

        //wordDocumentFile.CreatedOn = DateTime.Now;
        //wordDocumentFile.FileName = "word-file";

        //wordDocumentFile.Print();




        Shape[] shapes = {new Circle(), new Rectangle(), new Triangle()};

        foreach (Shape shape in shapes)
        {
            shape.Draw();
        }

        
    }
}
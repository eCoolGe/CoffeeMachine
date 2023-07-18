﻿using CoffeeMachine.Data;
using CoffeeMachine.Model;
using CoffeeMachine.Parsing;
using CoffeeMachine.Processing;

Console.WriteLine("---------------------------------------");
Console.WriteLine("  Wired Brain Coffee - Data Processor  ");
Console.WriteLine("---------------------------------------");
Console.WriteLine();

const string fileName = "CoffeeMachineData.csv";
string[] csvLines = File.ReadAllLines(fileName);

MachineDataItem[] machineDataItems = CsvLineParser.Parse(csvLines);

var machineDataProcessor = new MachineDataProcessor(new ConsoleCoffeeCountStore());
machineDataProcessor.ProcessItems(machineDataItems);

Console.WriteLine();
Console.WriteLine($"File {fileName} was successfully processed!");

Console.ReadLine();
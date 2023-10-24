﻿
// This file was auto-generated by ML.NET Model Builder. 

using Winequality_red_Console;

// Create single instance of sample data from first line of dataset for model input
Winequality_red.ModelInput sampleData = new Winequality_red.ModelInput()
{
    Fixed_acidity = 7.8F,
    Volatile_acidity = 0.88F,
    Citric_acid = 0F,
    Residual_sugar = 2.6F,
    Chlorides = 0.098F,
    Free_sulfur_dioxide = 25F,
    Total_sulfur_dioxide = 67F,
    Density = 0.9968F,
    PH = 3.2F,
    Sulphates = 0.68F,
    Alcohol = 9.8F,
};

// Make a single prediction on the sample data and print results
var predictionResult = Winequality_red.Predict(sampleData);

Console.WriteLine("Using model to make single prediction -- Comparing actual Quality with predicted Quality from sample data...\n\n");


Console.WriteLine($"Fixed_acidity: {7.8F}");
Console.WriteLine($"Volatile_acidity: {0.88F}");
Console.WriteLine($"Citric_acid: {0F}");
Console.WriteLine($"Residual_sugar: {2.6F}");
Console.WriteLine($"Chlorides: {0.098F}");
Console.WriteLine($"Free_sulfur_dioxide: {25F}");
Console.WriteLine($"Total_sulfur_dioxide: {67F}");
Console.WriteLine($"Density: {0.9968F}");
Console.WriteLine($"PH: {3.2F}");
Console.WriteLine($"Sulphates: {0.68F}");
Console.WriteLine($"Alcohol: {9.8F}");
Console.WriteLine($"Quality: {5F}");


Console.WriteLine($"\n\nPredicted Quality: {predictionResult.PredictedLabel}\n\n");
Console.WriteLine("=============== End of process, hit any key to finish ===============");
Console.ReadKey();


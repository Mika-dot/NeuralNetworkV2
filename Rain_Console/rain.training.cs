﻿﻿// This file was auto-generated by ML.NET Model Builder. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers.FastTree;
using Microsoft.ML.Trainers;
using Microsoft.ML;

namespace Rain_Console
{
    public partial class Rain
    {
        /// <summary>
        /// Retrains model using the pipeline generated as part of the training process. For more information on how to load data, see aka.ms/loaddata.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <param name="trainData"></param>
        /// <returns></returns>
        public static ITransformer RetrainPipeline(MLContext mlContext, IDataView trainData)
        {
            var pipeline = BuildPipeline(mlContext);
            var model = pipeline.Fit(trainData);

            return model;
        }

        /// <summary>
        /// build the pipeline that is used from model builder. Use this function to retrain model.
        /// </summary>
        /// <param name="mlContext"></param>
        /// <returns></returns>
        public static IEstimator<ITransformer> BuildPipeline(MLContext mlContext)
        {
            // Data process configuration with pipeline data transformations
            var pipeline = mlContext.Transforms.ReplaceMissingValues(new []{new InputOutputColumnPair(@"temp", @"temp"),new InputOutputColumnPair(@"inflation", @"inflation"),new InputOutputColumnPair(@"Friday", @"Friday"),new InputOutputColumnPair(@"Saturday", @"Saturday"),new InputOutputColumnPair(@"Sunday", @"Sunday"),new InputOutputColumnPair(@"Thursday", @"Thursday"),new InputOutputColumnPair(@"Tuesday", @"Tuesday"),new InputOutputColumnPair(@"Wednesday", @"Wednesday"),new InputOutputColumnPair(@"Annul Closing of Accounts Day", @"Annul Closing of Accounts Day"),new InputOutputColumnPair(@"Babu Jagjivan Ram Jayanti", @"Babu Jagjivan Ram Jayanti"),new InputOutputColumnPair(@"Bakrid / Eid al Adha", @"Bakrid / Eid al Adha"),new InputOutputColumnPair(@"Christmas Day", @"Christmas Day"),new InputOutputColumnPair(@"Diwali", @"Diwali"),new InputOutputColumnPair(@"Dr Ambedkar Jayanti", @"Dr Ambedkar Jayanti"),new InputOutputColumnPair(@"Eid e Milad", @"Eid e Milad"),new InputOutputColumnPair(@"Gandhi Jayanti", @"Gandhi Jayanti"),new InputOutputColumnPair(@"Ganesh Chaturthi", @"Ganesh Chaturthi"),new InputOutputColumnPair(@"Good Friday", @"Good Friday"),new InputOutputColumnPair(@"Holi", @"Holi"),new InputOutputColumnPair(@"Idul Fitr", @"Idul Fitr"),new InputOutputColumnPair(@"Independence Day", @"Independence Day"),new InputOutputColumnPair(@"Janmashtami", @"Janmashtami"),new InputOutputColumnPair(@"Kanuma Panduga", @"Kanuma Panduga"),new InputOutputColumnPair(@"Maha Ashtami", @"Maha Ashtami"),new InputOutputColumnPair(@"Maha Shivaratri", @"Maha Shivaratri"),new InputOutputColumnPair(@"Makar Sankranti", @"Makar Sankranti"),new InputOutputColumnPair(@"Muharram", @"Muharram"),new InputOutputColumnPair(@"Pongal", @"Pongal"),new InputOutputColumnPair(@"Ram Navami", @"Ram Navami"),new InputOutputColumnPair(@"Republic Day", @"Republic Day"),new InputOutputColumnPair(@"Ugadi", @"Ugadi"),new InputOutputColumnPair(@"Vijaya Dashami", @"Vijaya Dashami"),new InputOutputColumnPair(@"Energy Required (MU)", @"Energy Required (MU)")})      
                                    .Append(mlContext.Transforms.Text.FeaturizeText(inputColumnName:@"Date",outputColumnName:@"Date"))      
                                    .Append(mlContext.Transforms.Concatenate(@"Features", new []{@"temp",@"inflation",@"Friday",@"Saturday",@"Sunday",@"Thursday",@"Tuesday",@"Wednesday",@"Annul Closing of Accounts Day",@"Babu Jagjivan Ram Jayanti",@"Bakrid / Eid al Adha",@"Christmas Day",@"Diwali",@"Dr Ambedkar Jayanti",@"Eid e Milad",@"Gandhi Jayanti",@"Ganesh Chaturthi",@"Good Friday",@"Holi",@"Idul Fitr",@"Independence Day",@"Janmashtami",@"Kanuma Panduga",@"Maha Ashtami",@"Maha Shivaratri",@"Makar Sankranti",@"Muharram",@"Pongal",@"Ram Navami",@"Republic Day",@"Ugadi",@"Vijaya Dashami",@"Energy Required (MU)",@"Date"}))      
                                    .Append(mlContext.Transforms.NormalizeMinMax(@"Features", @"Features"))      
                                    .Append(mlContext.Regression.Trainers.FastTreeTweedie(new FastTreeTweedieTrainer.Options(){NumberOfLeaves=4,MinimumExampleCountPerLeaf=19,NumberOfTrees=29,MaximumBinCountPerFeature=1022,FeatureFraction=0.664784209009052,LearningRate=0.999999776672986,LabelColumnName=@"rain",FeatureColumnName=@"Features"}));

            return pipeline;
        }
    }
}

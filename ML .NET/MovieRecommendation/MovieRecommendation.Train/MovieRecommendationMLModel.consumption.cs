﻿// This file was auto-generated by ML.NET Model Builder. 
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace MovieRecommendation_Train
{
    public partial class MovieRecommendationMLModel
    {
        /// <summary>
        /// model input class for MovieRecommendationMLModel.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [LoadColumn(0)]
            [ColumnName(@"userId")]
            public float UserId { get; set; }

            [LoadColumn(1)]
            [ColumnName(@"movieId")]
            public float MovieId { get; set; }

            [LoadColumn(2)]
            [ColumnName(@"rating")]
            public float Rating { get; set; }

            [LoadColumn(3)]
            [ColumnName(@"timestamp")]
            public float Timestamp { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for MovieRecommendationMLModel.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            public float Score { get; set; }
        }
        #endregion

        private static string MLNetModelPath = Path.GetFullPath("MovieRecommendationMLModel.zip");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }
    }
}

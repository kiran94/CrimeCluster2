﻿namespace com.kiranpatel.crimecluster.framework.tests
{
	using System;
	using NUnit.Framework;
	using Moq; 

	/// <summary>
	/// Model evaluation tests.
	/// </summary>
	[TestFixture]
	public class ModelEvaluationTests
	{
		/// <summary>
		/// The mixed markov model mock.
		/// </summary>
		private Mock<IMixedMarkovModel> mixedMarkovModel;

		/// <summary>
		/// The incident service mock.
		/// </summary>
		private Mock<IIncidentService> incidentService;

		/// <summary>
		/// The distance measure mock.
		/// </summary>
		private Mock<IDistanceMeasure> distanceMeasure; 

		/// <summary>
		/// The logger mock.
		/// </summary>
		private Mock<ILogger> logger;

		/// <summary>
		/// Sets up.
		/// </summary>
		[SetUp]
		public void SetUp()
		{
			this.mixedMarkovModel = new Mock<IMixedMarkovModel>();
			this.incidentService = new Mock<IIncidentService>();
			this.distanceMeasure = new Mock<IDistanceMeasure>(); 
			this.logger = new Mock<ILogger>(); 
		}

		/// <summary>
		/// Ensures in the normal case, the model is evaluated. 
		/// </summary>
		[Test]
		public void Evaluate_NormalCase_ModelEvaluated()
		{
			throw new NotImplementedException(); 
		}

		/// <summary>
		/// Gets the instance.
		/// </summary>
		/// <returns>The instance.</returns>
		private ModelEvaluation GetInstance()
		{
			return new ModelEvaluation(
				this.mixedMarkovModel.Object, 
				this.incidentService.Object,  
				this.distanceMeasure.Object,
				this.logger.Object);
		}
	}
}
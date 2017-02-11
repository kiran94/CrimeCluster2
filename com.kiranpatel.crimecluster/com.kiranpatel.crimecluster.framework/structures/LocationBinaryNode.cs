﻿namespace com.kiranpatel.crimecluster.framework
{
	using System.Collections.Generic;

	/// <summary>
	/// A single location binary node which stores a Latitude and then a hashset of longitudes
	/// </summary>
	public class LocationBinaryNode
	{
		/// <summary>
		/// Gets the latitude.
		/// </summary>
		/// <value>The latitude.</value>
		public double Latitude { get; private set; }

		/// <summary>
		/// Gets or sets the longitude list.
		/// </summary>
		/// <value>The longitude list.</value>
		private HashSet<double> LongitudeList { get; set; }

		/// <summary>
		/// Gets or sets the left LocationBinaryNode to this
		/// </summary>
		/// <value>The left.</value>
		public LocationBinaryNode left { get; set; }

		/// <summary>
		/// Gets or sets the right LocationBinaryNode to this
		/// </summary>
		/// <value>The right.</value>
		public LocationBinaryNode right { get; set; } 

		/// <summary>
		/// Initializes a new instance of the <see cref="T:com.kiranpatel.crimecluster.framework.LocationBinaryNode"/> class.
		/// </summary>
		/// <param name="latitude">Latitude.</param>
		/// <param name="longitude">Longitude.</param>
		public LocationBinaryNode(double latitude, double longitude)
		{
			this.Latitude = latitude;
			this.LongitudeList = new HashSet<double>();

			this.addLongitude(longitude); 
		}

		/// <summary>
		/// Checks whether the passed longitude is within the longitude list
		/// </summary>
		/// <returns><c>true</c>, if latitude was found, <c>false</c> otherwise.</returns>
		/// <param name="longitude">flag indicating if the latitude was found.</param>
		public bool hasLongitude(double longitude)
		{
			return this.LongitudeList.Contains(longitude); 
		}

		/// <summary>
		/// Adds the longitude to the longitude list. 
		/// </summary>
		/// <param name="longitude">Longitude.</param>
		public void addLongitude(double longitude)
		{
			this.LongitudeList.Add(longitude); 
		}
	}
}
///////////////////////////////////////////////////////////
//  ML_City.cs
//  Implementation of the Class ML_City
//  Generated by Enterprise Architect
//  Created on:      04-Sep-2020 11:30:29 PM
//  Original author: Ignacio Andre Keiniger
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;




namespace TPANUAL {
	public class ML_City {

		public ML_PlaceSmall country;
		public ML_PlaceSmall state;
		public List<ML_PlaceSmall> neighborhoods;
		public ML_GeoInformation geo_information;
		public String id;
		public String name;

		public ML_City(){

		}

		~ML_City(){

		}

	}

}
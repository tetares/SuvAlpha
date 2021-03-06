﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public struct RESOURCES {
    public int fuels;
    public int foods;
    public int water;
    public int guns;
    public int medical_kits;
    public int repair_tools;
    public int radios;
    public bool ship_break;
}

public class ShipStatus : MonoBehaviour {
    private RESOURCES resources;

    public int StartFuels;
    public int StartFoods;
    public int StartWater;
    public int StartGuns;
    public int StartMedicalKits;
    public int StartRepairTools;
    public int StartRadios;

    void Awake( ) {
		init( );
	}

    public void setNewShip( ) {
        PlayerPrefs.SetInt( "Fuels", StartFuels );
        PlayerPrefs.SetInt( "Foods", StartFoods );
        PlayerPrefs.SetInt( "Water", StartWater );
        PlayerPrefs.SetInt( "Guns", StartGuns );
        PlayerPrefs.SetInt( "MedicalKits", StartMedicalKits );
        PlayerPrefs.SetInt( "RepairTools", StartRepairTools );
        PlayerPrefs.SetInt( "Radios", StartRadios );
        resources.ship_break = false;
        PlayerPrefs.Save( );
    }

    void init( ) {
        resources.fuels = PlayerPrefs.GetInt( "Fuels" );
        resources.foods = PlayerPrefs.GetInt( "Foods" );
        resources.water = PlayerPrefs.GetInt( "Water" );
        resources.guns = PlayerPrefs.GetInt( "Guns" );
        resources.medical_kits = PlayerPrefs.GetInt( "MedicalKits" );
        resources.repair_tools = PlayerPrefs.GetInt( "RepairTools" );
        resources.radios = PlayerPrefs.GetInt( "Radios" );
        if ( PlayerPrefs.GetInt( "Broken" ) == 1 ) {
            resources.ship_break = true;
        } else {
            resources.ship_break = false;
        }
    }

    public void saveData( ) {
        PlayerPrefs.SetInt( "Fuels", resources.fuels );
        PlayerPrefs.SetInt( "Foods", resources.foods );
        PlayerPrefs.SetInt( "Water", resources.water );
        PlayerPrefs.SetInt( "Guns", resources.guns );
        PlayerPrefs.SetInt( "MedicalKits", resources.medical_kits );
        PlayerPrefs.SetInt( "RepairTools", resources.repair_tools );
        PlayerPrefs.SetInt( "Radios", resources.radios );
        if ( resources.ship_break ) {
            PlayerPrefs.SetInt( "Broken", 1 );
        }
        PlayerPrefs.Save( );
    }

    public bool isShipBreak() { return resources.ship_break; }
    public void setShipBreak(bool breaked) { resources.ship_break = breaked; }
    public RESOURCES getResources( ) { return resources; }

    public void setFuels( int fuels ) {
        resources.fuels = fuels;
        if ( resources.fuels <= 0 ) {
            resources.fuels = 0;
            return;
        }
    }
    public void setFoods( int foods ) {
        resources.foods = foods;
        if ( resources.foods <= 0 ) {
            resources.foods = 0;
            return;
        }
    }
    public void setWater( int water ) {
        resources.water = water;
        if ( resources.water <= 0 ) {
            resources.water = 0;
            return;
        }
    }
    public void setGuns( int guns ) {
        resources.guns = guns;
        if ( resources.guns <= 0 ) {
            resources.guns = 0;
            return;
        }
    }
    public void setMedicalKits( int medical_kits ) {
        resources.medical_kits = medical_kits;
        if ( resources.medical_kits <= 0 ) {
            resources.medical_kits = 0;
            return;
        }
    }
    public void setRadios( int radios ) {
        resources.radios = radios;
        if ( resources.radios <= 0 ) {
            resources.radios = 0;
            return;
        }
    }
    public void setRepairTools( int repair_tools ) {
        resources.repair_tools = repair_tools;
        if ( resources.repair_tools <= 0 ) {
            resources.repair_tools = 0;
            return;
        }
    }
    public void setShipBreakWithBool( bool breaken ) {
        resources.ship_break = breaken;
    }

    public void setShipBreak( int breaken ) {
        if ( breaken == 1 ) {
            resources.ship_break = true;
        } else {
            resources.ship_break = false;
        }
    }
}



//그냥 나중에 Player.Prefs로
/*public void saveGameDataCsv( ) {
		using ( var writer = new CsvFileWriter ("Assets/Resources/Game_Data.csv")) {
			List<string> columns = new List<string> () {
				"Days",
				"Selects",
				"Fuels",
				"Foods",
				"Water",
				"Guns",
				"Medikal Kits",
				"Repair Tools",
				"Radios",
			};// making Index Row
			writer.WriteRow (columns);
			columns.Clear ();

			columns.Add ("40"); // Name
			columns.Add ("99"); // Level
			columns.Add ("999"); // Hp
			columns.Add ("5000"); // Exp
			columns.Add ("99"); // Str
			columns.Add ("50"); // Dex
			columns.Add ("80"); // Con
			columns.Add ("40"); // Int
			columns.Add ("40"); // Int
			writer.WriteRow (columns);
			columns.Clear ();
		}
	}

	public void saveCharaDataCsv( ) { //그냥 나중에 Player.Prefs로
		using (var writer = new CsvFileWriter ("Assets/Resources/Chara_Data.csv")) {
			List<string> columns = new List<string> () {
				"Character",
				"Place",
				"Foods",
				"Water",
				"Health",
				"Loyalty",
				"Death",
				"Disease"
			};// making Index Row
			writer.WriteRow (columns);
			columns.Clear ();

			columns.Add ("Bbulle"); // Name
			columns.Add ("99"); // Level
			columns.Add ("999"); // Hp
			columns.Add ("5000"); // Exp
			columns.Add ("99"); // Str
			columns.Add ("50"); // Dex
			columns.Add ("80"); // Con
			columns.Add ("40"); // Int
			writer.WriteRow (columns);
			columns.Clear ();

			columns.Add ("Kukai"); // Name
			columns.Add ("50"); // Level
			columns.Add ("666"); // Hp
			columns.Add ("3500"); // Exp
			columns.Add ("66"); // Str
			columns.Add ("66"); // Dex
			columns.Add ("44"); // Con
			columns.Add ("22"); // Int
			writer.WriteRow (columns);
			columns.Clear ();
		}
	}*/

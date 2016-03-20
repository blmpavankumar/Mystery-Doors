package com.pack2;

import java.util.Locale;
import android.app.Activity;
import android.os.Bundle;
import android.database.sqlite.SQLiteDatabase;
import android.content.ContentValues;
	 
public class Sqlite extends Activity 
{
	/** Called when the activity is first created. */
	@Override
	public void onCreate(Bundle savedInstanceState) 
	{
		super.onCreate(savedInstanceState);
		setContentView(R.layout.main);
		SQLiteDatabase db;
		db = openOrCreateDatabase("TestData.db"
		, SQLiteDatabase.CREATE_IF_NECESSARY
		, null
		);
		db.setVersion(1); 
		db.setLocale(Locale.getDefault()); 
		db.setLockingEnabled(true);	 
		final String CREATE_TABLE_COUNTRIES = 
		"CREATE TABLE tbl_countries (" 
		+ "id INTEGER PRIMARY KEY AUTOINCREMENT," 
		+ "country_name TEXT);"; 
		final String CREATE_TABLE_STATES =	 
		"CREATE TABLE tbl_states ("	 
		+ "id INTEGER PRIMARY KEY AUTOINCREMENT,"	 
		+ "state_name TEXT);";	 
		db.execSQL(CREATE_TABLE_COUNTRIES);	 
		db.execSQL(CREATE_TABLE_STATES);
		ContentValues values = new ContentValues();
			 
			values.put("country_name", "India");
			 
			db.insert("tbl_countries", null, values);
			
			//final String view="select * from tbl_countries;";
			//db.execSQL(view);
			 
		//	sqlite> select * from tbl_countries;
			 
			//select * from tbl_countries;
			 
			//1|India
	}
}
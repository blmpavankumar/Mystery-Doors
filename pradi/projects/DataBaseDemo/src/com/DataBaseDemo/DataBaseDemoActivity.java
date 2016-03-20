package com.DataBaseDemo;

import android.app.Activity;
import android.content.ContentValues;
import android.database.Cursor;
import android.database.SQLException;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class DataBaseDemoActivity extends Activity {
    /** Called when the activity is first created. */
	SQLiteDatabase db;
	Button btnInsert;
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.main);
        
        btnInsert=(Button)findViewById(R.id.button1);
        
        try{
        
        db=openOrCreateDatabase("StudentDB",SQLiteDatabase.CREATE_IF_NECESSARY,null);
        
        db.execSQL("Create Table Temp(id integer,name text)");
        
        }catch(SQLException e)
        {
        	
        }
        
        btnInsert.setOnClickListener(new View.OnClickListener() {
			
			@Override
			public void onClick(View v) {
				// TODO Auto-generated method stub
				
				EditText eid=(EditText) findViewById(R.id.editText1);
				EditText ename=(EditText)findViewById(R.id.editText2);
				
				ContentValues values=new ContentValues();
				values.put("id", eid.getText().toString());
				values.put("name", ename.getText().toString());
				if((db.insert("temp", null, values))!=-1)
				{
					Toast.makeText(DataBaseDemoActivity.this, "Record Successfully Inserted", 2000).show();
				}
				else
				{
					Toast.makeText(DataBaseDemoActivity.this, "Insert Error", 2000).show();
				}
				eid.setText("");
				ename.setText("");
				
				Cursor c=db.rawQuery("SELECT * FROM temp",null);
				
				c.moveToFirst();
				while(!c.isAfterLast())
				{
					Toast.makeText(DataBaseDemoActivity.this,c.getString(0)+ " "+c.getString(1), 1000).show();
					c.moveToNext();
				}
				c.close();
			}
		});
    }
    
    @Override
    protected void onStop() {
    	// TODO Auto-generated method stub
    	db.close();
    	super.onStop();
    }
    
}
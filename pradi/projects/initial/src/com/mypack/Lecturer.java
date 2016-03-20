package com.mypack;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class Lecturer extends Activity 
{
	  EditText txtName;
    /** Called when the activity is first created. */
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.lecturer);
        txtName=(EditText)findViewById(R.id.widget32);
        Button b1=(Button) findViewById(R.id.widget33);
        b1.setOnClickListener(new OnClickListener()
        {
        	String s="12345";
        	
			@Override
			public void onClick(View v)
			{
				// TODO Auto-generated method stub
				Toast.makeText(Lecturer.this,
						"LOADING", Toast.LENGTH_SHORT).show();
			   try
			   {
				   Thread.sleep(1500);
			   } 
			   catch (InterruptedException e) 
			   {
				   // TODO Auto-generated catch block
				   e.printStackTrace();
			   }
			   Intent myintent=new Intent();
				myintent.setClass(getApplicationContext(),Lect_Preference.class);
				startActivity(myintent);	
			}	
        }
        );

    }
}
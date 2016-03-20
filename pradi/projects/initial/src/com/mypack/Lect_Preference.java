package com.mypack;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.Toast;

public class Lect_Preference extends Activity {
    /** Called when the activity is first created. */
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.lect_preference);
        Button b1=(Button) findViewById(R.id.widget34);
        Button b2=(Button) findViewById(R.id.widget36);
        b1.setOnClickListener(new OnClickListener()
        {
			@Override
			public void onClick(View v)
			{
				// TODO Auto-generated method stub
				Toast.makeText(Lect_Preference.this,
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
				myintent.setClass(getApplicationContext(),Lect_weekdays.class);
				startActivity(myintent);	
			}	
        }
        );
        b2.setOnClickListener(new OnClickListener()
        {
			@Override
			public void onClick(View v)
			{
				// TODO Auto-generated method stub
				Toast.makeText(Lect_Preference.this,
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
				myintent.setClass(getApplicationContext(),Lect_sims_login.class);
				startActivity(myintent);	
			}	
        }
        );


    }
}
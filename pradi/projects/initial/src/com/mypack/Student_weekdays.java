package com.mypack;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.Toast;

public class Student_weekdays extends Activity implements OnClickListener {
    /** Called when the activity is first created. */
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.student_weekdays);
        Button b1=(Button) findViewById(R.id.widget37);
        Button b2=(Button) findViewById(R.id.widget38);
        Button b3=(Button) findViewById(R.id.widget39);
        Button b4=(Button) findViewById(R.id.widget40);
        Button b5=(Button) findViewById(R.id.widget41);
        Button b6=(Button) findViewById(R.id.widget42);
        
        b1.setOnClickListener(new OnClickListener()
        {
			@Override
			public void onClick(View v)
			{
				// TODO Auto-generated method stub
				Toast.makeText(Student_weekdays.this,
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
				myintent.setClass(getApplicationContext(),Time_table.class);
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
				Toast.makeText(Student_weekdays.this,
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
				myintent.setClass(getApplicationContext(),Time_table.class);
				startActivity(myintent);	
			}	
        }
        );
        
        b3.setOnClickListener(new OnClickListener()
        {
			@Override
			public void onClick(View v)
			{
				// TODO Auto-generated method stub
				Toast.makeText(Student_weekdays.this,
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
				myintent.setClass(getApplicationContext(),Time_table.class);
				startActivity(myintent);	
			}	
        }
        );
        
        b4.setOnClickListener(new OnClickListener()
        {
			@Override
			public void onClick(View v)
			{
				// TODO Auto-generated method stub
				Toast.makeText(Student_weekdays.this,
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
				myintent.setClass(getApplicationContext(),Time_table.class);
				startActivity(myintent);	
			}	
        }
        );
        
        b5.setOnClickListener(new OnClickListener()
        {
			@Override
			public void onClick(View v)
			{
				// TODO Auto-generated method stub
				Toast.makeText(Student_weekdays.this,
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
				myintent.setClass(getApplicationContext(),Time_table.class);
				startActivity(myintent);	
			}	
        }
        );
        
        b6.setOnClickListener(new OnClickListener()
        {
			@Override
			public void onClick(View v)
			{
				// TODO Auto-generated method stub
				Toast.makeText(Student_weekdays.this,
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
				myintent.setClass(getApplicationContext(),Time_table.class);
				startActivity(myintent);	
			}	
        }
        );
 
    }

	@Override
	public void onClick(View arg0) {
		// TODO Auto-generated method stub
		
	}
}
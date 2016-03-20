package com.mypack;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

public class STime_table extends Activity {
	TextView t2;
    /** Called when the activity is first created. */
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.stime_table);
        
        Bundle bundle = this.getIntent().getExtras();
        String param1 = bundle.getString("param1");
        t2 = (TextView) findViewById(R.id.textView1);
        t2.setText(param1);
      //  Button b1=(Button) findViewById(R.id.widget32);
       // Button b2=(Button) findViewById(R.id.widget48);
        
    }
}
package com.mypack;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.Toast;

public class Student_sims_choice extends Activity implements OnClickListener {
    /** Called when the activity is first created. */
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.student_sims_choice);
        Button b1=(Button) findViewById(R.id.widget52);
        Button b2=(Button) findViewById(R.id.widget53);
 
    }

	@Override
	public void onClick(View arg0) {
		// TODO Auto-generated method stub
		
	}
}
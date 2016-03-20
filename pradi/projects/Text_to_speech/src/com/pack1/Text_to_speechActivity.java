package com.pack1;
import android.app.Activity;
import android.os.Bundle;
import android.speech.tts.TextToSpeech;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import java.util.Locale;
import java.util.Random;
import android.os.Bundle;

public class Text_to_speechActivity extends Activity implements TextToSpeech.OnInitListener {
    /** Called when the activity is first created. */
	private static final String TAG = "TextToSpeechDemo";
    private TextToSpeech mTts;
    private Button mAgainButton;
    @Override
    public void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.main);
        mTts = new TextToSpeech(this,
        this  // TextToSpeech.OnInitListener
        );
        mAgainButton = (Button) findViewById(R.id.button1);
        mAgainButton.setOnClickListener(new View.OnClickListener()
        {
        	public void onClick(View v) 
        	{
                sayHello();      
        	}
        });
    }
    @Override
    public void onDestroy() 
    {
        if (mTts != null)
        {
            mTts.stop();
            mTts.shutdown();
        }
        super.onDestroy();
    }
	@Override
    // Implements TextToSpeech.OnInitListener.
    public void onInit(int status) 
	{
        // status can be either TextToSpeech.SUCCESS or TextToSpeech.ERROR.
        if (status == TextToSpeech.SUCCESS) 
        {
            // Set preferred language to US english.
            // Note that a language may not be available, and the result will indicate this.
            int result = mTts.setLanguage(Locale.ENGLISH);
            // Try this someday for some interesting results.
            // int result mTts.setLanguage(Locale.FRANCE);
            if (result == TextToSpeech.LANG_MISSING_DATA||result == TextToSpeech.LANG_NOT_SUPPORTED) 
            {
               // Lanuage data is missing or the language is not supported.
               Log.e(TAG, "Language is not available.");
            }
            else 
            {
                // Check the documentation for other possible result codes.
                // For example, the language may be available for the locale,
                // but not for the specified country and variant.
                // The TTS engine has been successfully initialized.
                // Allow the user to press the button for the app to speak again.
                mAgainButton.setEnabled(true);
                // Greet the user.
                sayHello();
            }
        } 
        else 
        {
            // Initialization failed.
            Log.e(TAG, "Could not initialize TextToSpeech.");
        }
    }
	/*private static final Random RANDOM = new Random();
	private static final String[] HELLOS =
	{
	      "Hello",
	      "Salutations",
	      "Greetings",
	      "10 30",
	      "What's crack-a-lackin?",
	      "That explains the stench!"
	};*/
	
	private void sayHello() 
	{
	        // Select a random hello.
			//int helloLength = HELLOS.length;
	        String h2= "10 30";	        
	        String h1="  hi   this    is    suraj  "+h2;
	        //String hello = HELLOS[RANDOM.nextInt(helloLength)];
	        mTts.speak(h1,
	            TextToSpeech.QUEUE_FLUSH,  // Drop all pending entries in the playback queue.
	            null);
	}
}
package com.d4nux.pruebawcf;

import android.app.Activity;
import android.os.AsyncTask;
import android.os.Bundle;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.TextView;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.URL;
import java.net.URLConnection;


public class MainActivity extends Activity {

    TextView text;
    String Line;
    StringBuilder sb = new StringBuilder();
    String name=null;
    Bundle bu;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        text = (TextView) findViewById(R.id.txtJson);
    }

    public void callWCF(View v) {
    LlamarWCF aux=new LlamarWCF();
        aux.execute();
    }

   /* Thread hilo = new Thread(new Runnable() {
        @Override
        public void run() {
            try{
                URL url = new URL("http://comparkte.com/chaira/Service1.svc/mostrarUsuario");
                URLConnection jc = url.openConnection();
                BufferedReader reader = new BufferedReader(new InputStreamReader(jc.getInputStream()));

                while((Line=reader.readLine()) != null){
                    sb.append(Line);
                }

                text.post(new Runnable() {
                    @Override
                    public void run() {
                        text.setText(sb.toString());
                    }
                });
            }
            catch (Exception e){
                Log.d("Error:", e.toString());
            }
        }
    });*/

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }
    private class LlamarWCF extends AsyncTask<Void,Void,Void>{



        @Override
        protected Void doInBackground(Void... voids) {
            try{
                URL url = new URL("http://comparkte.com/chaira/Service1.svc/mostrarUsuarios");
                URLConnection jc = url.openConnection();
                BufferedReader reader = new BufferedReader(new InputStreamReader(jc.getInputStream()));

                while((Line=reader.readLine()) != null){
                    sb.append(Line);
                }

            }
            catch (Exception e){
                Log.d("Error:", e.toString());
            }

            return null;
        }
        @Override
        protected void onPostExecute(Void aVoid) {
            super.onPostExecute(aVoid);
            text.setText(sb);
        }


    }

}

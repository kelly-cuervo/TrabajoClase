package dorioga.web;

import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.View;
import android.widget.TextView;

public class Explorador extends AppCompatActivity {
 private TextView mostrar;
    private String user="admin",pass="12345";
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_explorador);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        mostrar= (TextView) findViewById(R.id.morite);
        Bundle captura = getIntent().getExtras();
        System.out.print(captura.get("user")+" - "+user+"\n "+captura.get("pass")+" - "+pass);
        if(captura.get("user").equals(user) ){
            System.out.print(captura.get("user")+" - "+user+ "- "+captura.get("pass")+" - "+pass);
        }
            if(captura.get("pass").equals(pass)) {
                mostrar.setText("Ha ingresado correctamente el Usuario y la Contraseña " + captura.get("user"));
            }else{
            mostrar.setText("Error!!!" + "\n" + "Datos Incorrectos");
        }


        FloatingActionButton fab = (FloatingActionButton) findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Snackbar.make(view, "Replace with your own action", Snackbar.LENGTH_LONG)
                        .setAction("Action", null).show();
            }
        });
    }

}

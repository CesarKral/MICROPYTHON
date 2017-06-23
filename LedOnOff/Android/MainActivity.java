package com.example.cesar.ledonoff;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.Button;

import java.io.DataOutputStream;
import java.io.OutputStream;
import java.net.Socket;

public class MainActivity extends AppCompatActivity {

    Button on;
    Button off;
    Socket socketA;
    DataOutputStream doe;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        on = (Button)findViewById(R.id.btnOn);
        off = (Button)findViewById(R.id.btnOff);

        on.setOnClickListener( v -> {
            Runnable taskA = () -> {
                try {
                    String strON = "1";
                    socketA = new Socket("192.168.12.5", 5656);
                    OutputStream os = socketA.getOutputStream();
                    os.write(strON.getBytes("UTF-8"));
                    os.close();
                    socketA.close();
                }catch (Exception e){ System.out.println(e); }
            };
            new Thread(taskA).start();
        });

        off.setOnClickListener( v -> {
            Runnable taskB = () -> {
                try {
                    String strOFF = "0";
                    socketA = new Socket("192.168.12.5", 5656);
                    OutputStream os = socketA.getOutputStream();
                    os.write(strOFF.getBytes("UTF-8"));
                    os.close();
                    socketA.close();
                }catch (Exception e){ System.out.println(e); }
            };
            new Thread(taskB).start();
        });
    }
}

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package crud.sqlserver.pkg2024.alumnos;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

/**
 *
 * @author juancarlos
 */
public class conexion {
    
    public static Connection getConexion(){
    
    String url ="jdbc:sqlserver://localhost:1433;"
            + "database=escuela;"
            + "user=jc;"
            + "password=1234;";        
            
            try {
            
            Connection con =DriverManager.getConnection(url);
            return con;
            
            }catch (SQLException e){
            
            System.out.println(e.toString());
            
           return null; 
            }
            
    }
    
    
    
    
    
}

import java.io.*;
import java.util.*;

public class main{
	public static void main (String[] args) throws IOException {
		Vector vector = new Vector(20);

		for(int i =0;i<20;i++){
			vector.add(i+1);
		}
		Enumeration vec = vector.elements();
		Adapter myAdapter = new Adapter(vec);

		
		for(int j=0;j<20;j++){
			System.out.println(myAdapter.hasNext());
			System.out.println(myAdapter.next());
		}
		
		myAdapter.remove();
	}
}
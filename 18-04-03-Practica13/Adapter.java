import java.io.*;
import java.util.*;

public class Adapter implements Iterator{
	Enumeration enume;

	public Adapter(Enumeration enumer){
		enume = enumer;
	}
	@Override
	public boolean hasNext(){
		return enume.hasMoreElements();

	}
	@Override
	public Object next(){
		return enume.nextElement();
	}
	@Override
	public void remove(){
		System.out.println("No se puede");
	}
}
import java.io.*;
public class LowerInputStream extends FilterInputStream{
	public LowerInputStream(InputStream in){
		super(in);
	}

	public int read() throws IOException{
		int c = in.read();
		if(c == -1){
			return -1;
		}
		else{
			char letra = Character.toLowerCase((char)c);
			return letra;
		}
	}
}
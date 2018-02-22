import java.io.*;
public class main{
	public static void main(String[] args) throws IOException {
		int c;

		try{
			InputStream in = new LowerInputStream(new BufferedInputStream(new FileInputStream("test.txt")));

			while((c = in.read()) >= 0){
				System.out.print((char)c);
			}
			in.close();
		}
		catch(IOException e){
			e.printStackTrace();
		}
	}
}
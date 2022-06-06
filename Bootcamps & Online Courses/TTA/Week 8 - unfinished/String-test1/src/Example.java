
public class Example {

	public static void main(String[] args) {
		String sentence = "Are you as excited as I am ?";
		String reverseSentence = "";
		String[] splitted = sentence.split(" ");
		for (int i = splitted.length -2; i >= 0; i--)
		{
			reverseSentence = splitted[i];
			System.out.println(reverseSentence);
			}
		System.out.println("?");
		}
}

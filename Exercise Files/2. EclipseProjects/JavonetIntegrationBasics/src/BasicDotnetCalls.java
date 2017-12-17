import com.javonet.Javonet;
import com.javonet.JavonetException;
import com.javonet.api.NObject;

public class BasicDotnetCalls {

	public static void main(String[] args) throws JavonetException {
		// TODO Auto-generated method stub
		System.out.println("Rise & Shine & Ready to Test Busta!");
		// Javonet.activate("cyranova@msn.com", "x7L5-n2C9-x3Y4-Ze52-k9E5", JavonetFramework.v45);
		
		AddReferences();
		
		//TestCarSDK();
		TestStaticInstanceSDK();
	}
	
	private static void AddReferences() throws JavonetException {
		Javonet.addReference("CarComponent.dll");
		Javonet.addReference("StaticInstanceComponent.dll");
	}

	// 01_04	
	private static void TestCarSDK() throws JavonetException {	
		System.out.println("\nExercise 01_04\n-----------");
		NObject theCar = Javonet.New("CarSDK");
		String result = theCar.invoke("RevEngine");
		System.out.println(result);
	}
	
	// 03_01
	private static void TestStaticInstanceSDK() throws JavonetException {	
		System.out.println("\nExercise 03_01\n-----------");
		
		//Demo calling instance method
		NObject siaClass = Javonet.New("StaticInstanceSDK");
		int result = siaClass.invoke("MultiplyViaInstance",15,16);
		System.out.println(result);
		
		//Demo calling static method
		int result2 = Javonet.getType("StaticInstanceSDK").invoke("AddViaStatic",5,16);
		System.out.println(result2);
	}
	// 03_02
	// 03_03
	// 03_04
	// 03_05
	// 03_06

}

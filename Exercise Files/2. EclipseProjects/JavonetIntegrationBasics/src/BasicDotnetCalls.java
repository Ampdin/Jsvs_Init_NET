import com.javonet.Javonet;
import com.javonet.JavonetException;
import com.javonet.api.NObject;
import com.javonet.api.NType;

public class BasicDotnetCalls {

	public static void main(String[] args) throws JavonetException {
		// TODO Auto-generated method stub
		System.out.println("Rise & Shine & Ready to Test Busta!");
		// Javonet.activate("cyranova@msn.com", "x7L5-n2C9-x3Y4-Ze52-k9E5", JavonetFramework.v45);
		
		AddReferences();
		
		//TestCarSDK();
		//TestStaticInstanceSDK();
		TestFieldsPropertiesComponentSDK();
		PassingArgumentsSDK1();
	}

	private static void AddReferences() throws JavonetException {
		Javonet.addReference("CarComponent.dll");
		Javonet.addReference("StaticInstanceComponent.dll");
		Javonet.addReference("FieldsPropertiesComponent.dll");
		Javonet.addReference("PassingArgumentsSDK.dll");
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
	private static void TestFieldsPropertiesComponentSDK() throws JavonetException {
		System.out.println("\nExercise 03_02\n-----------");
		
		// Demo of static field
		NType sampleType = Javonet.getType("FieldsPropertiesSDK");
		sampleType.set("MyStaticField", 10);
		Integer staticVal = sampleType.get("MyStaticField");
		System.out.println("MyStaticField output " + staticVal);
		
		// Demo of instance field
		NObject sampleObj = Javonet.New("FieldsPropertiesSDK");
		sampleObj.set("MyInstanceField", 20);
		Integer instanceVal = sampleObj.get("MyInstanceField");
		System.out.println("MyInstanceField output " + instanceVal);
	}

	// 03_03
	private static void PassingArgumentsSDK1() throws JavonetException {
		
		// Demo Passing Reference-Type Arguments
		NOject objectWithProp = Javonet.New("ObjectWithProp");
		objectWithProp.set("PropTextValue", "This is an alert stored in .NET object prop");
		
		NOject objectUsingObjectProp = Javonet.New("ObjectUsingObjectProp");
		objectUsingObjectProp.invoke("DisplayPropValue",objectWithProp);
		objectUsingObjectProp.set("objProperty", objectWithProp);
		
		System.out.println("/n*** Displaying the value of the property " 
							+ "of an object instance that was set to the property ***\\n");
		
		System.out.println(objectUsingObjectProp.getRef("ObjProperty").get("PropTextValue").toString());
		
	}
	// 03_04
	// 03_05
	// 03_06

}

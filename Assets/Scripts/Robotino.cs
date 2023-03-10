//using UnityEngine;
//using UnityEngine.UI;
//using UnityEngine.Networking;
//using game4automation;

//public class WebRequestExample : MonoBehaviour
//{
//    // 网站的地址
//    public string url = "http://172.21.0.90/SQLData.php?";

//    // 三个按钮
//    public Button button1;
//    public Button button2;
//    public Button button3;

//    void Start()
//    {
//        // 为每个按钮添加事件处理程序
//        button1.onClick.AddListener(Request1);
//        button2.onClick.AddListener(Request2);
//        button3.onClick.AddListener(Request3);
//    }

//    // 发送第一个请求
//    void Request1()
//    {
//        StartCoroutine(SendRequest("param1=value1"));
//    }

//    // 发送第二个请求
//    void Request2()
//    {
//        StartCoroutine(SendRequest("param2=value2"));
//    }

//    // 发送第三个请求
//    void Request3()
//    {
//        StartCoroutine(SendRequest("param3=value3"));
//    }

//    IEnumerator SendRequest(string parameters)
//    {
//        using (UnityWebRequest webRequest = UnityWebRequest.Get(url + parameters))
//        {
//            // 发送请求
//            yield return webRequest.SendWebRequest();

//            // 检查请求是否有错误
//            if (webRequest.result != UnityWebRequest.Result.Success)
//            {
//                Debug.LogError($"Error: {webRequest.error}");
//            }
//            else
//            {
//                // 输出请求的结果
//                Debug.Log($"Response: {webRequest.downloadHandler.text}");
//            }
//        }
//    }
//}
//在上述代码中，我们创建了三个按钮button1、button2和button3，并将它们保存在变量中。
//    在Start()函数中，我们为每个按钮添加一个事件处理程序，当用户单击按钮时，将调用相应的请求函数Request1、Request2或Request3。
//    每个请求函数将调用一个名为SendRequest()的协程函数，该函数将使用UnityWebRequest类来连接到指定的网站，并发送包含指定参数的GET请求。在请求完成后，我们将请求结果输出到控制台。

//请注意，上述示例代码中的url变量是您要连接的网站地址。如果您需要向该网站发送带参数的请求，可以在url变量的末尾添加参数，例如：http://172.21.0.90/SQLData.php?param1=value1&param2=value2。




//御手洗白白
//我怎么知道Request1对应的是网站上的哪个按钮
//如果您要在Unity中创建按钮来对应网站上的按钮，则需要查看该网站的源代码，以确定每个按钮对应的参数和请求URL。
//    您可以通过右键单击网站上的按钮，并选择 "检查元素"（Inspect Element）选项来查看网站源代码。

//在网站源代码中，您可以查找每个按钮的HTML元素，并查看它们的属性。每个按钮通常都会具有一个“name”或“value”属性，该属性指定该按钮的值或名称。
//    您需要在Unity中的每个按钮中设置相应的名称或值，以便在单击该按钮时发送正确的参数和请求URL。

//另外，您还可以在Unity的WebRequest代码中设置参数的名称和值，以便它们匹配网站上按钮的名称或值。这样，当用户单击Unity中的按钮时，您发送的请求将具有与网站上相应按钮相同的参数。
using UnityEngine;

//一个人驱动自己的身体做各种事情的意志
public class WillComponent : MonoBehaviour
{
    public float OverallWill = 100; //总意志，减少外物而增进自己的愿望

    public  float FameWill = 100; //名（名也代表着被他人认同的渴望）

    public float MoneyWill = 100; //利

    public float PowerWill = 100; //权（权力的意志简单来说就是“以威逼利诱进行控制的能力”，具体表现为一个人对他人的控制、对事件进程的控制、对自己身体的控制、对物质世界的控制四个部分）

    public float SexWill = 100; //色

    public float PastimeWill = 100; //消遣（大部分人消遣是为了寻找快乐，但也有一部分“异常”群体寻找痛苦，两者都可以归结为“消遣”，也就是把时间花掉的欲望，一种对时间的消费欲导致了消遣行为）

    public float LoveWill = 100; //爱

    public float LiveWill = 100; //生存
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

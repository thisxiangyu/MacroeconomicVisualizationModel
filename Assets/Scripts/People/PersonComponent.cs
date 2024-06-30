using UnityEngine;

public class PersonComponent : MonoBehaviour
{
    float Health = 100;

    //人并没有善恶的属性，善恶是高概念，也没有利他和利己的区别，利他利己也是高概念。
    //正确的细胞级的描述是区分人格的排他性、融他性、对外消化力

    float IndividualExclusivity = 100; //人格排他性，抵御外物对自身影响的趋势

    float IndividualInclusivity = 100; //人格融他性，允许外物对自身影响的趋势

    float OutwardConsumptionDesire = 100; //对外消费欲，对外物施加影响的趋势

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

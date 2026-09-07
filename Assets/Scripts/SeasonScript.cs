using TMPro;
using UnityEngine;

public class SeasonScript : MonoBehaviour
{
  [SerializeField]  private Transform _sun;
  [SerializeField] private float  _speedX=2;
  [SerializeField] private float _rotateGlobal=0;
  [SerializeField] private int _day=0;
  [SerializeField] private int _monht=0;
  [SerializeField] private ParticalsChanger _particleSystem;
  [SerializeField] private TextMeshProUGUI textMeshProUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rotateGlobal=Mathf.Abs(_sun.rotation.x);
        _particleSystem.ChangeParticals(0);
        SetText();
    }
    private void SetText()
    {
        textMeshProUI.text= $"Day: {_day} Month: {_monht}";
    }
    void FixedUpdate()
    {
    float rotateX=Time.deltaTime*_speedX;
   _rotateGlobal+=rotateX;
 _sun.transform.Rotate(new Vector3(rotateX,0,0));
        if (_rotateGlobal>=360)
        {
            _rotateGlobal=0;
            _day+=1;
            if (_day >= 5)
            {
                _day=0;
                _monht+=1;

                if (_monht >= 4)
                {
                    _monht=0;
                }
                _particleSystem.ChangeParticals(_monht);
            }
            _sun.transform.rotation=Quaternion.Euler(Vector3.zero);
            SetText();
        }     
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

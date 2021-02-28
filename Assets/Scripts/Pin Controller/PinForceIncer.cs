using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class PinForceIncer : MonoBehaviour
{
    [Tooltip("Сила, с которой поднимаем предмет")] 
    [SerializeField] private float _forceUp;

    [Tooltip("Коэффициент для увеличения силы разброса")]
    [SerializeField] private float _scatterForceCoeff;

    private MainInputActions rigidbodyInputs;
    
    private Rigidbody[] _pinBodies;


    private void OnEnable()
    {
        rigidbodyInputs.RigidBodyInputs.Enable();
    }

    private void OnDisable()
    {
        rigidbodyInputs.RigidBodyInputs.Disable();
    }

    private void Awake()
    {
        rigidbodyInputs = new MainInputActions();
       
    }

    private void Start()
    {
        _pinBodies = GetComponentsInChildren<Rigidbody>().ToArray();
    }

    private void Update()
    {
        CheckInput();
    }

    private void CheckInput()
    {
        if (rigidbodyInputs.RigidBodyInputs.Up.triggered) AddUpForceToPin();
        else if (rigidbodyInputs.RigidBodyInputs.Scatter.triggered) AddRandomForceToPin();
    }

    private void AddUpForceToPin()
    {
        for (int i = 0; i < _pinBodies.Length; i++)
        {
            _pinBodies[i].AddForce(_forceUp * Vector3.up, ForceMode.Acceleration);
        }
    }

    private void AddRandomForceToPin()
    {
        for (int i = 0; i < _pinBodies.Length; i++)
        {
            _pinBodies[i].AddForce(_forceUp * _scatterForceCoeff * new Vector3(Random.Range(-1,1),Random.Range(-1,1),Random.Range(-1,1)), ForceMode.VelocityChange);
        }
    }
}

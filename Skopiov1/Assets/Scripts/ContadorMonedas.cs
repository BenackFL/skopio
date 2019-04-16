
//namespace Firebase.Sample.Database
//{
    //using Firebase;
    //using Firebase.Database;
    //using Firebase.Unity.Editor;
   // using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;
    using TMPro;
   // using MySql.Data.MySqlClient;
    using UnityEngine.SceneManagement;

    public class ContadorMonedas : MonoBehaviour
    {
        /*
        protected virtual void Start()
        {
            leaderBoard.Clear();
            leaderBoard.Add("Firebase Top " + MaxScores.ToString() + " Scores");

            FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task => {
                dependencyStatus = task.Result;
                if (dependencyStatus == DependencyStatus.Available)
                {
                    InitializeFirebase();
                }
                else
                {
                    Debug.LogError(
                      "Could not resolve all Firebase dependencies: " + dependencyStatus);
                }
            });
        }
        // Initialize the Firebase database:
        protected virtual void InitializeFirebase()
        {
            FirebaseApp app = FirebaseApp.DefaultInstance;
            // NOTE: You'll need to replace this url with your Firebase App's database
            // path in order for the database connection to work correctly in editor.
            app.SetEditorDatabaseUrl("https://skopio-640b0.firebaseio.com/");
            if (app.Options.DatabaseUrl != null)
                app.SetEditorDatabaseUrl(app.Options.DatabaseUrl);
            StartListener();
            isFirebaseInitialized = true;
        }

        protected void StartListener()
        {
            FirebaseDatabase.DefaultInstance
              .GetReference("Leaders").OrderByChild("score")
              .ValueChanged += (object sender2, ValueChangedEventArgs e2) => {
                  if (e2.DatabaseError != null)
                  {
                      Debug.LogError(e2.DatabaseError.Message);
                      return;
                  }
                  Debug.Log("Received values for Leaders.");
                  string title = leaderBoard[0].ToString();
                  leaderBoard.Clear();
                  leaderBoard.Add(title);
                  if (e2.Snapshot != null && e2.Snapshot.ChildrenCount > 0)
                  {
                      foreach (var childSnapshot in e2.Snapshot.Children)
                      {
                          if (childSnapshot.Child("score") == null
                    || childSnapshot.Child("score").Value == null)
                          {
                              Debug.LogError("Bad data in sample.  Did you forget to call SetEditorDatabaseUrl with your project id?");
                              break;
                          }
                          else
                          {
                              Debug.Log("Leaders entry : " +
                        //childSnapshot.Child("email").Value.ToString() + " - " +
                        childSnapshot.Child("score").Value.ToString());
                              leaderBoard.Insert(1, childSnapshot.Child("score").Value.ToString()
                        //+ "  " + childSnapshot.Child("email").Value.ToString());
                          };
                      }
                  }
              };
        }

        // Exit if escape (or back, on mobile) is pressed.
        protected virtual void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }

        // A realtime database transaction receives MutableData which can be modified
        // and returns a TransactionResult which is either TransactionResult.Success(data) with
        // modified data or TransactionResult.Abort() which stops the transaction with no changes.
        TransactionResult AddScoreTransaction(MutableData mutableData)
        {
            List<object> leaders = mutableData.Value as List<object>;

            if (leaders == null)
            {
                leaders = new List<object>();
            }
            else if (mutableData.ChildrenCount >= MaxScores)
            {
                // If the current list of scores is greater or equal to our maximum allowed number,
                // we see if the new score should be added and remove the lowest existing score.
                long minScore = long.MaxValue;
                object minVal = null;
                foreach (var child in leaders)
                {
                    if (!(child is Dictionary<string, object>))
                        continue;
                    long childScore = (long)((Dictionary<string, object>)child)["score"];
                    if (childScore < minScore)
                    {
                        minScore = childScore;
                        minVal = child;
                    }
                }
                // If the new score is lower than the current minimum, we abort.
                if (minScore > score)
                {
                    return TransactionResult.Abort();
                }
                // Otherwise, we remove the current lowest to be replaced with the new score.
                leaders.Remove(minVal);
            }

            // Now we add the new score as a new entry that contains the email address and score.
            Dictionary<string, object> newScoreMap = new Dictionary<string, object>();
            newScoreMap["score"] = contador_monedas;
            //newScoreMap["email"] = email;
            leaders.Add(newScoreMap);

            // You must set the Value to indicate data at that location has changed.
            mutableData.Value = leaders;
            return TransactionResult.Success(mutableData);
        }

        public void AddScore()
        {
            score = contador_monedas;
            //if (score == 0 || string.IsNullOrEmpty(email))
            if (score == 0)
            {
                DebugLog("invalid score.");
                return;
            }
            DebugLog(String.Format("Attempting to add score {0} {1}",
              score.ToString()));
            //email, score.ToString()));

            DatabaseReference reference = FirebaseDatabase.DefaultInstance.GetReference("Leaders");

            DebugLog("Running Transaction...");
            // Use a transaction to ensure that we do not encounter issues with
            // simultaneous updates that otherwise might create more than MaxScores top scores.
            reference.RunTransaction(AddScoreTransaction)
              .ContinueWith(task => {
                  if (task.Exception != null)
                  {
                      DebugLog(task.Exception.ToString());
                  }
                  else if (task.IsCompleted)
                  {
                      DebugLog("Transaction complete.");
                  }
              });
        } */
        //Tiempo

        public int id_usuario;
        public string auxi;


        public Text changingText;
        public Text problema;
        public Text acierto;
        //public TextMeshPro PreFab;

        public TextMeshPro m_Text;
        public TextMeshPro m_Text2;
        public TextMeshPro m_Text3;
        public TextMeshPro m_Text4;
        public TextMeshPro m_Text5;

        public static int contador_monedas = 0;
        public static int contador_problemas = 0;
        //Text m_MyText;

        int rando1 = 0, rando2 = 0, rando3 = 0, rando4 = 0, rando5 = 0, respuesta = 0, rno1, rno2, rno3, rno4, rno5;



        public void ObtenerID()
        {


            Debug.Log("El usuario es: " + id_usuario);
            //UPDATE `usuarios` SET `monedas_usuario` = '1' WHERE `usuarios`.`Id_usuarios` = 1;
            string _log = "`usuarios` SET `monedas_usuario` = '" + contador_monedas + "' WHERE `usuarios`.`Id_usuarios` = '" + id_usuario + "'";
            //AdminMYSQL _adminMYSQL = GameObject.Find("AdministradorBaseDatos").GetComponent<AdminMYSQL>();
            //MySqlDataReader Resultado = _adminMYSQL.Actualiza(_log);

        }

        public void OnTriggerEnter(Collider other)
        {
            Debug.Log("Colision");

            //contador_monedas++;
            //changingText.text = "" + contador_monedas;

            //auxi = other.GetComponent<TextMeshPro>().ToString();
            auxi = other.gameObject.GetComponent<TextMeshPro>().GetParsedText().ToString();

            Debug.Log("Es " + auxi);
            if (auxi == respuesta.ToString())
            {
                acierto.text = "Acertaste!";
                Debug.Log("Acerto");//Imprimir en imagen o text el acierto

                m_Text.text = "";
                m_Text2.text = "";
                m_Text3.text = "";
                m_Text5.text = "";
                m_Text4.text = "";
                contador_monedas++;



                crearProblema();
            }

            else if (auxi == "")
            {
                Debug.Log("Jaja valor invisible");//Trucazo del magaso
            }
            else
            {
                acierto.text = "La respuesta era " + respuesta;
                Debug.Log("Fallo");//Imprimir en imagen o text el fallo
                m_Text.text = "";
                m_Text2.text = "";
                m_Text3.text = "";
                m_Text5.text = "";
                m_Text4.text = "";


                crearProblema();
            }

        }

        void Start()
        {
            if (contador_problemas == 0)
            {
                contador_monedas = ControladorCambio.monedas2;
                id_usuario = ControladorCambio.id_usuario2;
                crearProblema();

            }
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void crearProblema()
        {

            //Nivel 1, ligar score de Int art
            //Random randomizer = new Random();
            rando1 = Random.Range(1, 10);
            rando2 = Random.Range(1, 10);
            rando3 = Random.Range(1, 10);
            rando4 = Random.Range(1, 10);
            rando5 = Random.Range(1, 10);

            problema.text = rando1 + "+" + rando2;

            respuesta = 0;
            respuesta = rando1 + rando2;
            rno1 = rando1 + rando3;
            rno2 = rando2 + rando3;
            rno3 = rando3 + rando4;
            rno4 = rando1 + rando5;
            rno5 = rando4 + rando2;


            //Respuestas
            m_Text = Instantiate(m_Text);
            m_Text2 = Instantiate(m_Text2);
            m_Text3 = Instantiate(m_Text3);
            m_Text5 = Instantiate(m_Text5);
            m_Text4 = Instantiate(m_Text4);

            //Ciclo problemas

            int randomsito = 0;
            randomsito = Random.Range(1, 10);
            switch (randomsito)
            {
                case 1:
                    m_Text.text = "" + respuesta;
                    m_Text5.text = "" + rno1;
                    break;
                case 2:
                    m_Text2.text = "" + respuesta;
                    m_Text4.text = "" + rno3;
                    break;
                case 3:
                    m_Text3.text = "" + respuesta;
                    m_Text2.text = "" + rno2;
                    break;
                case 4:
                    m_Text4.text = "" + respuesta;
                    m_Text.text = "" + rno5;
                    break;
                case 5:
                    m_Text5.text = "" + respuesta;
                    m_Text2.text = "" + rno3;
                    break;
                case 6:
                    m_Text.text = "" + respuesta;
                    m_Text2.text = "" + rno4;
                    break;
                case 7:
                    m_Text2.text = "" + respuesta;
                    m_Text3.text = "" + rno2;
                    break;
                case 8:
                    m_Text3.text = "" + respuesta;
                    m_Text5.text = "" + rno1;
                    break;
                case 9:
                    m_Text4.text = "" + respuesta;
                    m_Text.text = "" + rno1;
                    break;
                case 10:
                    m_Text5.text = "" + respuesta;
                    m_Text3.text = "" + rno3;
                    break;
            }



            contador_problemas++;
            if (contador_problemas == 10)
            {//Terminar escena
             //SceneManager.LoadScene(SceneManager.GetActiveScene ().buildIndex + 1);
                ControladorCambio.monedas2 = contador_monedas;
                ObtenerID();
                contador_problemas = 0;
                SceneManager.LoadScene(4);
            }
            changingText.text = "" + contador_monedas;



        }


    }
//}

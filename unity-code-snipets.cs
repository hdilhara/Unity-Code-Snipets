
        /*Reference One Object by its type ( i.e. Script type )*/
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Key Entered!");
            Circle[] triggers = FindObjectOfType<circle>().GetComponent<Rigidbody2D>().gravityScale = 10;
        }

        /*Reference Objects by its type ( i.e. Script type )*/
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Key Entered!");
            Circle[] triggers = FindObjectsOfType<circle>();
            foreach (circle t in triggers)
            {
                t.GetComponent<Rigidbody2D>().gravityScale = 10;
            }
        }


         /*Reference Objects by its TAG type */

         GameObject[] greenBalls = GameObject.FindGameObjectsWithTag("GreenBall");

         foreach (GameObject g in greenBalls)
          {
              g.GetComponent<Rigidbody2D>().gravityScale = -10;
          }

        /* play sound  first add AudioSource Component */
        [SerializeField] AudioClip PaddleHitAudio;
        AudioSource audioSource;
        start(){
            audioSource = gameObject.GetComponent<AudioSource>();
        }
        if(gameHasStarted && collision.gameObject.name.Equals("Paddle"))
        {
            audioSource.clip = PaddleHitAudio ;
            audioSource.Play();
        }
        //PlayOneShot() not to distrub sounds; Its require clip as arg
        audioSource.PlayOneShot(audioSource.clip);
        

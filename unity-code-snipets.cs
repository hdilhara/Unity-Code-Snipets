
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


         /*Reference Objects by its TAG type ( i.e. Script type )*/

         GameObject[] greenBalls = GameObject.FindGameObjectsWithTag("GreenBall");

            foreach (GameObject g in greenBalls)
            {
                g.GetComponent<Rigidbody2D>().gravityScale = -10;
            }

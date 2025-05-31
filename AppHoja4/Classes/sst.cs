
namespace AppHoja4.Classes
{
    internal class sst
    {

        private Node head;

        public sst()
        {
            this.head = null;
        }

        public sst(Node insert) {
            this.head = insert;
        }

        public void push(Node insert) {

            if (head == null)
            {
                head = insert;
            }
            else
            {
                insert.Prev = head;
                head.Next = insert;

                head = insert;
            }
        }

        public Node[] ObtenerTodos()
        {
            Node aux = head;
            int cantidad = 0;

            while (aux != null)
            {
                cantidad++;
                aux = aux.Prev;
            }

            Node[] uni= new Node[cantidad];

            aux = head;
            int i = 0;
            while (aux != null)
            {
                uni[i] = aux;
                aux = aux.Prev;
                i++;
            }

            return uni;
        }

    }
}

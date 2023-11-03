namespace Lib_4
{
    public class Pair
    {
        public int P1 { get; set; } // ������ ����� ����
        public int P2 { get; set; } // ������ ����� ����

        /// <summary>
        /// ������������������� ����������� ��� ������ Pair
        /// </summary>
        /// <param name="p1">������ ����� ����</param>
        /// <param name="p2">������ ����� ����</param>
        public Pair(int p1, int p2)
        {
            P1 = p1;
            P2 = p2;
        }

        /// <summary>
        /// ������������� �������� ��� ���� �����
        /// </summary>
        /// <param name="p1">������ ����� ����</param>
        /// <param name="p2">������ ����� ����</param>
        public void SetParams(int p1, int p2)
        {
            P1 = p1;
            P2 = p2;
        }

        /// <summary>
        /// ������������� �������� ��� ���� ����� �� ������ ���� �����
        /// </summary>
        /// <param name="pair">���� �����</param>
        public void SetParams(Pair pair)
        {
            P1 = pair.P1;
            P2 = pair.P2;
        }

        /// <summary>
        /// �������� "������" ��� ��������� ���� ���
        /// </summary>
        /// <param name="first">���� 1</param>
        /// <param name="second">���� 2</param>
        /// <returns>������� ��������</returns>
        public static bool operator >(Pair first, Pair second)
        {
            return first.P1 > first.P2 || first.P1 == first.P2 && second.P1 > second.P2;
        }

        /// <summary>
        /// �������� "������" ��� ��������� ���� ���
        /// </summary>
        /// <param name="first">���� 1</param>
        /// <param name="second">���� 2</param>
        /// <returns>������� ��������</returns>
        public static bool operator <(Pair first, Pair second)
        {
            return first.P1 < first.P2 || first.P1 == first.P2 && second.P1 < second.P2;
        }
    }
}

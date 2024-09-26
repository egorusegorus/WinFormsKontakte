



namespace DBAcceskontakt
{
    public interface IDbAcces     {
        public List<Kontakt> KontakteLaden();
        public void KontaktHinzufügen(Kontakt k);
        public void KontaktÄndern(Kontakt k);
        public void KontaktLöschen(Kontakt k);
    }
}
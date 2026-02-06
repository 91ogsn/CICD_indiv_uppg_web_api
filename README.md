# Individuell uppgift CI/CD

Detta projekt är ett **C# Web API** som erbjuder **kryptering och avkryptering** av text med ett enkelt **Caesar-chiffer**.
API:t byggs och deployas automatiskt med **GitHub Actions** och publiceras till **AWS Elastic Beanstalk**.

---

## Funktionalitet

- Kryptering av text med Caesar-chiffer
- Avkryptering av tidigare krypterad text
- Endpoints tillgängliga via HTTP GET
- Automatisk CI/CD-pipeline till AWS Elastic Beanstalk

---

## Länkar Publicerat API

### Root:
http://krypteringapi-env.eba-4ubwba4s.eu-north-1.elasticbeanstalk.com/

### Kryptering
http://krypteringapi-env.eba-4ubwba4s.eu-north-1.elasticbeanstalk.com/encrypt?text=Hej%20abc!

### Avkryptering
http://krypteringapi-env.eba-4ubwba4s.eu-north-1.elasticbeanstalk.com/decrypt?text=Khm%20def!

---

## Caesar-chiffer
Caesar-chiffret fungerar genom att varje bokstav i texten flyttas ett fast antal steg framåt eller bakåt i alfabetet.
- Endast bokstäver påverkas (övriga tecken lämnas orörda)

---

## Författare
Stefan Östling
GitHub: https://github.com/<91ogsn>

# Deep-Client

**Deep-Client** è l'applicazione ufficiale per comunicare con **Deep Mining Protocol**. Questa repository contiene il codice del client e la documentazione necessaria per comprenderne il funzionamento.

### Caratteristiche

- **Comunicazione unica**: Il Deep-Client è il metodo ufficiale e consigliato per interagire con il protocollo.
- **Facilità di modifica**: Tutti i comandi in entrata e uscita sono documentati per agevolare eventuali modifiche.
- **Supporto per client alternativi**: In futuro, client creati dalla community potranno essere linkati qui per facilitare l'interoperabilità.

> **Nota**: Sconsigliamo di utilizzare client non ufficiali nelle prime fasi di utilizzo.

---

## Comandi supportati

### Struttura dei comandi

Alcuni comandi richiedono l'autenticazione del client prima di essere eseguiti. I comandi disponibili sono elencati nella tabella seguente:

| **Comando**           | **Descrizione**                                                                    |
| --------------------- | ---------------------------------------------------------------------------------- |
| `plotPrice`           | Restituisce il costo dei plot selezionati in USDT.                                 |
| `register`            | Aggiunge un utente al database dopo la transazione in USDT per l'acquisto di plot. |
| `simulazione`         | Calcola in modo simulato il mining per fornire una stima.                          |
| `withdrawal`          | Richiede il prelievo di chia (xch).                                            |
| `home`                | Aggiorna le fee per il prelievo di Chia.                                           |
| `rendita`             | Aggiorna la rendita in base al deposito effettuato.                                |
| `balance`             | Mostra i bilanci del protocollo.                                                   |
| `bonus`               | Visualizza il valore dei bonus disponibili.                                        |
| `swap`                | Esegue lo swap tra le coin selezionate.                                            |
| `swap_result`         | Simula uno swap e mostra il risultato.                                             |
| `update_coin_price`   | Invia al client il prezzo delle monete supportate.                                 |
| `update_user_balance` | Invia il bilancio dell'utente (se registrato).                                     |
| `updatePassword`      | Confronta la Seed Phrase fornita dal client con quella salvata.                    |
| `resetPassword`       | Consente il reset della password.                                                  |
| `data`                | Invia informazioni specifiche al client.                                           |
| `login`               | Effettua il login del client.                                                      |
| `staking`             | Permette lo staking delle coin.                                                    |
| `unstake`             | Permette l'operazione inversa dello staking (unstake).                             |
| `transaction`         | Ottiene l'elenco delle transazioni.                                                |

---

## Supporto per client della community

In futuro, client alternativi creati dalla community saranno elencati qui. Se desideri contribuire, inviaci il tuo progetto per la revisione.

---

## Contribuire

Se vuoi contribuire al miglioramento di questo client, segui questi passi:

1. Forka la repository.
2. Crea una nuova branch con le tue modifiche.
3. Invia una pull request per la revisione.

---

> Per eventuali problemi o domande, consulta la sezione **Issues** della repository.


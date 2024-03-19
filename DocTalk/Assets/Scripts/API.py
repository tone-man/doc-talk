import sys
import requests
import json

print("Communicating with the Convai API...")
url = "https://api.convai.com/character/update"

payload = json.dumps({
  "charID": sys.argv[1],
  "backstory": sys.argv[2],
#   "voiceType": "MALE",
  "charName": "TestPatient"
})
headers = {
  'CONVAI-API-KEY': '973cfcd9dfc0a419a537087bfd2cdb61',
  'Content-Type': 'application/json'
}

response = requests.request("POST", url, headers=headers, data=payload)

print(response.text)